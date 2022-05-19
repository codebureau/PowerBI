using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharePointURLCleaner
{
    
    public partial class ExternalTool : Form
    {
        private SharePointURLTranslationViewModel model;
        public ExternalTool()
        {
            InitializeComponent();
        }

        
        private void sharePointURL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ExternalTool_Load(object sender, EventArgs e)
        {
            this.model = new SharePointURLTranslationViewModel();
            this.model.AutoLoadFromClipboard = Properties.Settings.Default.AutoLoadFromClipboard;

            //Binding
            this.autoClipboardGetText.DataBindings.Add(new Binding("Checked", this.model, "AutoLoadFromClipboard", false, DataSourceUpdateMode.OnPropertyChanged));
            this.sharePointURL.DataBindings.Add(new Binding("Text", this.model, "InputURL", false, DataSourceUpdateMode.OnPropertyChanged));
            this.powerBIURL.DataBindings.Add(new Binding("Text", this.model, "OutputURL"));

            if (this.model.AutoLoadFromClipboard)
                this.model.LoadFromClipboard(); 
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.model.OutputUrl);
        }

        private void loadFromClipboard_Click(object sender, EventArgs e)
        {
            this.model.LoadFromClipboard();
        }
    }
}
