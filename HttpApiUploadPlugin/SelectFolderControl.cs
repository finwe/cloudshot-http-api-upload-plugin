using System;
using System.IO;
using System.Windows.Forms;

namespace HttpApiUploadPlugin
{
  public sealed partial class SelectFolderControl : UserControl
  {
    public string DefaultPath { get; set; }

    public string Description { get; set; } = "Select folder";

    public string SelectedPath
    {
      get => txtPath.Text;
      set
      {
        txtPath.Text = value;
        UpdateUIElements();
      }
    }

    public SelectFolderControl()
    {
      InitializeComponent();
      UpdateUIElements();
    }

    private static bool TryGetFullPath(string path, out string fullPath)
    {
      try
      {
        fullPath = Path.GetFullPath(path);
        return true;
      }
      catch (Exception)
      {
        fullPath = null;
        return false;
      }
    }

    private void UpdateUIElements()
    {
      toolTip.SetToolTip(txtPath, txtPath.Text);
      resetLink.Visible = !string.IsNullOrEmpty(DefaultPath) && DefaultPath != SelectedPath;
    }

    private void OnBrowseClick(object sender, EventArgs e)
    {
      using (var dialog = new FolderBrowserDialog())
      {
        dialog.Description = Description;

        if (TryGetFullPath(SelectedPath, out var fullPath))
        {
          dialog.SelectedPath = fullPath;
        }

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          SelectedPath = dialog.SelectedPath;
          txtPath.SelectionStart = txtPath.Text.Length;
        }
      }
    }

    private void OnPathChanged(object sender, EventArgs e)
    {
      UpdateUIElements();
    }

    private void OnResetPath(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SelectedPath = DefaultPath;
    }
  }
}
