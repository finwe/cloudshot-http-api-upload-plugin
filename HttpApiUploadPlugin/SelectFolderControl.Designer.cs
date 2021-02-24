namespace HttpApiUploadPlugin
{
  partial class SelectFolderControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.resetLink = new System.Windows.Forms.LinkLabel();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.txtPath, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.resetLink, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 206);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // txtPath
      // 
      this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPath.Location = new System.Drawing.Point(0, 2);
      this.txtPath.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(414, 25);
      this.txtPath.TabIndex = 1;
      this.txtPath.TextChanged += new System.EventHandler(this.OnPathChanged);
      // 
      // btnBrowse
      // 
      this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBrowse.Location = new System.Drawing.Point(418, 1);
      this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(97, 27);
      this.btnBrowse.TabIndex = 2;
      this.btnBrowse.Text = "Select ...";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.OnBrowseClick);
      // 
      // resetLink
      // 
      this.resetLink.AutoSize = true;
      this.resetLink.Font = new System.Drawing.Font("Segoe UI", 9.75F);
      this.resetLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.resetLink.LinkColor = System.Drawing.Color.DodgerBlue;
      this.resetLink.Location = new System.Drawing.Point(3, 30);
      this.resetLink.Name = "resetLink";
      this.resetLink.Size = new System.Drawing.Size(100, 17);
      this.resetLink.TabIndex = 3;
      this.resetLink.TabStop = true;
      this.resetLink.Text = "Reset to default";
      this.resetLink.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
      this.resetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnResetPath);
      // 
      // SelectFolderControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(100, 30);
      this.Name = "SelectFolderControl";
      this.Size = new System.Drawing.Size(515, 206);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.LinkLabel resetLink;
  }
}
