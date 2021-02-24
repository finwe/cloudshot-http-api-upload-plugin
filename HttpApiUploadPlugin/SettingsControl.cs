using System;
using System.Windows.Forms;
using CloudShot.Core.Interfaces;

namespace HttpApiUploadPlugin
{
  public partial class SettingsControl : UserControl, ISettingsControl
  {
    private readonly Storage _storage;

    public IImageStorage Storage => _storage;

    public Control Control => this;

    public SettingsControl(Storage storage)
    {
      _storage = storage;

      InitializeComponent();

      apiUrlTextBox.Text = "";
    }

    public void Loading()
    {
      PluginSettings settings = _storage.GetSettings();
      apiUrlTextBox.Text = settings.ApiUrl;
      copyStyleDropDown.SelectedIndex = settings.CopyStyle;
    }

    public bool ValidateData()
    {
      Uri uriResult;
      bool result = Uri.TryCreate(apiUrlTextBox.Text, UriKind.Absolute, out uriResult);

      if (result || apiUrlTextBox.Text == "") {
        return true;
      }
       
      MessageBox.Show("Invalid URL", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      apiUrlTextBox.Focus();
      return false;
    }

    public void Save()
    {
      PluginSettings settings = _storage.GetSettings();
      settings.ApiUrl = apiUrlTextBox.Text;
      settings.CopyStyle = copyStyleDropDown.SelectedIndex;
      _storage.SaveSettings(settings);
    }

    public void CancelClicked() { }
  }
}
