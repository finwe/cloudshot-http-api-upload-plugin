using System.ComponentModel;

namespace HttpApiUploadPlugin
{
  public enum CopyStyle
  {
    [Description("URL")] Url = 0,
    [Description("IMG tag")] ImgTag,
    [Description("IMG tag with empty WIDTH attribute")] ImgTagWithEmptyWidth
  }

  public class PluginSettings
  {
    public string ApiUrl { get; set; } = string.Empty;

    public CopyStyle CopyStyle { get; set; } = CopyStyle.Url;
  }
}