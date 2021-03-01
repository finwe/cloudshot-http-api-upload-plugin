namespace HttpApiUploadPlugin
{
	partial class SettingsControl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.apiUrlTextBox = new System.Windows.Forms.TextBox();
      this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
      this.apiUrlHeader = new CloudShot.Core.Controls.HeaderLabel();
      this.copyTypeHeader = new CloudShot.Core.Controls.HeaderLabel();
      this.copyStyleDropDown = new System.Windows.Forms.ComboBox();
      this.helpTextLabel = new System.Windows.Forms.Label();
      this.urlLabel = new System.Windows.Forms.LinkLabel();
      this.tableLayout.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolTip
      // 
      this.toolTip.AutomaticDelay = 200;
      this.toolTip.AutoPopDelay = 0;
      this.toolTip.InitialDelay = 200;
      this.toolTip.ReshowDelay = 0;
      this.toolTip.ShowAlways = true;
      // 
      // apiUrlTextBox
      // 
      this.apiUrlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.apiUrlTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.apiUrlTextBox.Location = new System.Drawing.Point(3, 35);
      this.apiUrlTextBox.Name = "apiUrlTextBox";
      this.apiUrlTextBox.Size = new System.Drawing.Size(429, 23);
      this.apiUrlTextBox.TabIndex = 20;
      // 
      // tableLayout
      // 
      this.tableLayout.ColumnCount = 1;
      this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayout.Controls.Add(this.apiUrlHeader, 0, 0);
      this.tableLayout.Controls.Add(this.apiUrlTextBox, 0, 1);
      this.tableLayout.Controls.Add(this.copyTypeHeader, 0, 2);
      this.tableLayout.Controls.Add(this.copyStyleDropDown, 0, 3);
      this.tableLayout.Controls.Add(this.helpTextLabel, 0, 4);
      this.tableLayout.Controls.Add(this.urlLabel, 0, 5);
      this.tableLayout.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayout.Location = new System.Drawing.Point(0, 0);
      this.tableLayout.Name = "tableLayout";
      this.tableLayout.RowCount = 6;
      this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayout.Size = new System.Drawing.Size(435, 420);
      this.tableLayout.TabIndex = 21;
      // 
      // apiUrlHeader
      // 
      this.apiUrlHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.apiUrlHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.apiUrlHeader.Location = new System.Drawing.Point(0, 0);
      this.apiUrlHeader.Margin = new System.Windows.Forms.Padding(0);
      this.apiUrlHeader.Name = "apiUrlHeader";
      this.apiUrlHeader.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
      this.apiUrlHeader.Size = new System.Drawing.Size(435, 32);
      this.apiUrlHeader.TabIndex = 14;
      this.apiUrlHeader.Text = "API URL ENDPOINT";
      this.apiUrlHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // copyTypeHeader
      // 
      this.copyTypeHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.copyTypeHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.copyTypeHeader.Location = new System.Drawing.Point(0, 82);
      this.copyTypeHeader.Margin = new System.Windows.Forms.Padding(0);
      this.copyTypeHeader.Name = "copyTypeHeader";
      this.copyTypeHeader.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
      this.copyTypeHeader.Size = new System.Drawing.Size(435, 32);
      this.copyTypeHeader.TabIndex = 14;
      this.copyTypeHeader.Text = "RESULT CLIPBOARD STYLE";
      this.copyTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // copyStyleDropDown
      // 
      this.copyStyleDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
      this.copyStyleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.copyStyleDropDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.copyStyleDropDown.Location = new System.Drawing.Point(3, 117);
      this.copyStyleDropDown.Name = "copyStyleDropDown";
      this.copyStyleDropDown.Size = new System.Drawing.Size(429, 23);
      this.copyStyleDropDown.TabIndex = 21;
      // 
      // helpTextLabel
      // 
      this.helpTextLabel.AutoSize = true;
      this.helpTextLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.helpTextLabel.ForeColor = System.Drawing.Color.Gray;
      this.helpTextLabel.Location = new System.Drawing.Point(10, 184);
      this.helpTextLabel.Margin = new System.Windows.Forms.Padding(10, 20, 3, 20);
      this.helpTextLabel.Name = "helpTextLabel";
      this.helpTextLabel.Size = new System.Drawing.Size(356, 150);
      this.helpTextLabel.TabIndex = 22;
      this.helpTextLabel.Text = resources.GetString("helpTextLabel.Text");
      // 
      // urlLabel
      // 
      this.urlLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.urlLabel.Location = new System.Drawing.Point(10, 374);
      this.urlLabel.Margin = new System.Windows.Forms.Padding(10, 20, 3, 20);
      this.urlLabel.Name = "urlLabel";
      this.urlLabel.Size = new System.Drawing.Size(422, 23);
      this.urlLabel.TabIndex = 23;
      this.urlLabel.TabStop = true;
      this.urlLabel.Text = "https://github.com/finwe/cloudshot-http-api-upload-plugin";
      this.urlLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
      // 
      // SettingsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayout);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "SettingsControl";
      this.Size = new System.Drawing.Size(435, 420);
      this.tableLayout.ResumeLayout(false);
      this.tableLayout.PerformLayout();
      this.ResumeLayout(false);

		}

		#endregion
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.TextBox apiUrlTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayout;
    private CloudShot.Core.Controls.HeaderLabel apiUrlHeader;
    private CloudShot.Core.Controls.HeaderLabel copyTypeHeader;
    private System.Windows.Forms.ComboBox copyStyleDropDown;
    private System.Windows.Forms.Label helpTextLabel;
    private System.Windows.Forms.LinkLabel urlLabel;
  }
}
