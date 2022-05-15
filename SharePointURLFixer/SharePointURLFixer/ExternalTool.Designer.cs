namespace SharePointURLFixer
{
    partial class ExternalTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sharePointURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.powerBIURL = new System.Windows.Forms.TextBox();
            this.autoClipboardGetText = new System.Windows.Forms.CheckBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.loadFromClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SharePoint URL";
            // 
            // sharePointURL
            // 
            this.sharePointURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sharePointURL.Location = new System.Drawing.Point(206, 111);
            this.sharePointURL.Multiline = true;
            this.sharePointURL.Name = "sharePointURL";
            this.sharePointURL.Size = new System.Drawing.Size(1047, 142);
            this.sharePointURL.TabIndex = 1;
            this.sharePointURL.TextChanged += new System.EventHandler(this.sharePointURL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Power BI URL";
            // 
            // powerBIURL
            // 
            this.powerBIURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerBIURL.Location = new System.Drawing.Point(205, 293);
            this.powerBIURL.Multiline = true;
            this.powerBIURL.Name = "powerBIURL";
            this.powerBIURL.ReadOnly = true;
            this.powerBIURL.Size = new System.Drawing.Size(1048, 144);
            this.powerBIURL.TabIndex = 3;
            // 
            // autoClipboardGetText
            // 
            this.autoClipboardGetText.AutoSize = true;
            this.autoClipboardGetText.Location = new System.Drawing.Point(25, 22);
            this.autoClipboardGetText.Name = "autoClipboardGetText";
            this.autoClipboardGetText.Size = new System.Drawing.Size(360, 36);
            this.autoClipboardGetText.TabIndex = 4;
            this.autoClipboardGetText.Text = "Automatically Read Clipboard";
            this.autoClipboardGetText.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(1103, 469);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(150, 69);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "&Copy Text";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // loadFromClipboard
            // 
            this.loadFromClipboard.Location = new System.Drawing.Point(445, 12);
            this.loadFromClipboard.Name = "loadFromClipboard";
            this.loadFromClipboard.Size = new System.Drawing.Size(281, 83);
            this.loadFromClipboard.TabIndex = 6;
            this.loadFromClipboard.Text = "&Load From Clipboard";
            this.loadFromClipboard.UseVisualStyleBackColor = true;
            this.loadFromClipboard.Click += new System.EventHandler(this.loadFromClipboard_Click);
            // 
            // ExternalTool
            // 
            this.AcceptButton = this.copyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 566);
            this.Controls.Add(this.loadFromClipboard);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.autoClipboardGetText);
            this.Controls.Add(this.powerBIURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sharePointURL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExternalTool";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SharePoint URL Fixer";
            this.Load += new System.EventHandler(this.ExternalTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sharePointURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox powerBIURL;
        private System.Windows.Forms.CheckBox autoClipboardGetText;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button loadFromClipboard;
    }
}

