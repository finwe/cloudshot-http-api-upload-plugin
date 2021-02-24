using System;
using System.IO;

namespace HttpApiUploadPlugin
{
  public class PluginSettings
  {
    public string ApiUrl { get; set; } = "";

    public int CopyStyle { get; set; } = 0;
  }
}
