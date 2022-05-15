using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SharePointURLFixer
{
    internal class SharePointURLTranslationViewModel : INotifyPropertyChanged
    {
        private bool autoloadFromClipboard = false;
        private string inputUrl = string.Empty;

        public bool AutoLoadFromClipboard
        {
            get
            {
                return autoloadFromClipboard;
            } 
            set
            {
                this.autoloadFromClipboard = value;
                Properties.Settings.Default.AutoLoadFromClipboard = value;
                Properties.Settings.Default.Save();

                NotifyPropertyChanged();
            }
        }
        public string InputUrl { get
            {
                return inputUrl;
            } 
            set 
            {
                inputUrl = value;
                NotifyPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual string Translate(string input)
        {
            if (!string.IsNullOrEmpty(input) )
            {
                string pattern = @"(:[f|w|x|p|b]:\/)";
                string substitution = "";
                RegexOptions options = RegexOptions.Multiline;

                Regex regex = new Regex(pattern, options);
                string result = regex.Replace(input, substitution);
                return result;
            }
            else
                return input;
        }

        public string OutputUrl { 
            get 
            {
                return Translate(InputUrl);
            }
        }

        public void LoadFromClipboard()
        {
            this.InputUrl = Clipboard.GetText();
        }
    }
}
