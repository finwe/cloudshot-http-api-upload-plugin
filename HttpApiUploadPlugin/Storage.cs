using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CloudShot.Core.Interfaces;
using CloudShot.Core.Types;
using CloudShot.Core.Utils;

namespace HttpApiUploadPlugin
{
  public class Storage : ImageStorage<PluginSettings>
  {
    public override Image Logo { get; }

    public Storage() : base("HTTP API Upload", "Upload image to a generic HTTP API")
    {
      var manager = new DpiResourcesManager(LocalResources.ResourceManager);
      Logo = manager.GetImage(nameof(LocalResources.folder));
    }

    public override async Task<StorageSaveResult> SaveImage(byte[] data, string shotName)
    {
      PluginSettings settings = GetSettings();

      if (string.IsNullOrEmpty(settings.ApiUrl))
      {
        return new StorageSaveResult(SavingResultCode.RequiresOptionsSetup, "API URL has to be set");
      }

      var values = new Dictionary<string, string>
      {
        {"dataurl", GetDataURL(data, shotName)}
      };

      try
      {
        using (var client = new HttpClient())
        {
          var content = new FormUrlEncodedContent(values);
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

          HttpResponseMessage response = await client.PostAsync(settings.ApiUrl, content);

          response.EnsureSuccessStatusCode();

          string responseString = await response.Content.ReadAsStringAsync();
          string stringToClipboard;

          switch (settings.CopyStyle)
          {
            case CopyStyle.ImgTag:
              stringToClipboard = GetUrlAsImgTag(responseString);
              break;
            case CopyStyle.ImgTagWithEmptyWidth:
              stringToClipboard = GetUrlAsImgTagWithWidth(responseString);
              break;
            default:
              stringToClipboard = responseString;
              break;
          }

          return new StorageSaveResult(shotName, stringToClipboard);
        }
      }
      catch (HttpRequestException ex)
      {
        return new StorageSaveResult(SavingResultCode.Failed, ex);
      }
    }

    public static string GetDataURL(byte[] data, string shotName)
    {
      string mime = Path.GetExtension(shotName).Replace(".", "") == "png" ? "png" : "jpeg";
      return "data:image/" + mime + ";base64," + Convert.ToBase64String(data);
    }

    public static string GetUrlAsImgTag(string url)
    {
      return "<img src=\"" + url + "\">";
    }

    public static string GetUrlAsImgTagWithWidth(string url)
    {
      return "<img src=\"" + url + "\" width=\"\">";
    }

    public override ISettingsControl CreateSettingsControl() => new SettingsControl(this);
  }
}