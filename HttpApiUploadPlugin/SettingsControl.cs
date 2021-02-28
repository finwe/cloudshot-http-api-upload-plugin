using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using CloudShot.Core.Interfaces;

namespace HttpApiUploadPlugin
{
  public partial class SettingsControl : UserControl, ISettingsControl
  {
    private class CopyStyleItem
    {
      public CopyStyle CopyStyle { get; }

      public string DisplayName { get; }

      public CopyStyleItem(CopyStyle copyStyle)
      {
        CopyStyle = copyStyle;
        DisplayName = copyStyle.GetDescription();
      }
    }

    private readonly Storage _storage;
    private readonly List<CopyStyleItem> _copyStyleItems = new List<CopyStyleItem>();

    public IImageStorage Storage => _storage;

    public Control Control => this;

    public SettingsControl(Storage storage)
    {
      _storage = storage;

      foreach (CopyStyle value in Enum.GetValues(typeof(CopyStyle)))
      {
        _copyStyleItems.Add(new CopyStyleItem(value));
      }

      InitializeComponent();

      apiUrlTextBox.Text = string.Empty;
      copyStyleDropDown.DataSource = _copyStyleItems;
      copyStyleDropDown.ValueMember = nameof(CopyStyleItem.CopyStyle);
      copyStyleDropDown.DisplayMember = nameof(CopyStyleItem.DisplayName);
    }

    public void Loading()
    {
      PluginSettings settings = _storage.GetSettings();
      apiUrlTextBox.Text = settings.ApiUrl;
      copyStyleDropDown.SelectedValue = settings.CopyStyle;
    }

    public bool ValidateData()
    {
      bool result = Uri.TryCreate(apiUrlTextBox.Text, UriKind.Absolute, out Uri _);

      if (result || string.IsNullOrEmpty(apiUrlTextBox.Text))
      {
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
      settings.CopyStyle = (CopyStyle) copyStyleDropDown.SelectedValue;
      _storage.SaveSettings(settings);
    }

    public void CancelClicked()
    {
    }

    private void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://github.com/finwe/cloudshot-http-api-upload-plugin");
    }
  }
}