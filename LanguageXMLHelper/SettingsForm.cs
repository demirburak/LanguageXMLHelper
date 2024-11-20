using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageXMLHelper
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            txtSuffix.Text = AppSettings.Suffix;
            txtPrefix.Text = AppSettings.Prefix;
            chcHasTranslate.Checked = AppSettings.HasTranslate;
            txtTranslationUrl.Text = AppSettings.TranslateUrl;
        }

        private void SaveSettings()
        {
            AppSettings.Suffix = txtSuffix.Text;
            AppSettings.Prefix = txtPrefix.Text;
            AppSettings.HasTranslate = chcHasTranslate.Checked;
            AppSettings.TranslateUrl = txtTranslationUrl.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }
    }
}
