using System.Diagnostics;
using System.Text.RegularExpressions;

namespace LanguageXMLHelper
{
    public partial class LanguageXMLHelperForm : Form
    {
        public LanguageXMLHelperForm()
        {
            InitializeComponent();
            AddColumns();
        }

        private void AddColumns()
        {
            dgv.Columns.Add("Turkish", "Turkish XML");
            dgv.Columns.Add("English", "English XML");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEnglishRoot.Text)) ConvertRootName(txtEnglish.Text);
            InsertToDataGridView();
        }

        private void InsertToDataGridView()
        {
            txtTurkish.Text = Clean(txtTurkish.Text);
            txtEnglish.Text = Clean(txtEnglish.Text);
            string tr = $"<text name=\"{txtEnglishRoot.Text}\">{txtTurkish.Text}</text>";
            string en = $"<text name=\"{txtEnglishRoot.Text}\">{txtEnglish.Text}</text>";
            if (!string.IsNullOrWhiteSpace(txtTurkish.Text) || !string.IsNullOrWhiteSpace(txtEnglish.Text))
            {
                dgv.Rows.Add(tr, en);
                CleanDoubleRecords();
            }

        }

        private void CleanDoubleRecords()
        {
            List<(string, string)> list = new();
            for (int i = dgv.Rows.Count - 1; i >= 0; i--)
            {
                (string, string) check = new();
                check.Item1 = dgv.Rows[i].Cells["English"].Value.ToString();
                check.Item2 = dgv.Rows[i].Cells["Turkish"].Value.ToString();
                if (list.Contains(check))
                {
                    dgv.Rows.RemoveAt(i);
                }
                else
                {
                    list.Add(check);
                }
            }
        }

        private string Clean(string text)
        {
            List<string> cleanThisChars = new() { "\r", "\n" };
            List<string> spaceThisChars = new() { "\t" };

            foreach (string c in cleanThisChars)
            {
                text = text.Replace(c, string.Empty);
            }

            foreach (string c in spaceThisChars)
            {
                text = text.Replace(c, " ");
            }

            return text;
        }

        private string ConvertRootName(string rootName)
        {
            char[] chars = new[] { ' ', '\r', '\n', '\t', '\b' };
            string[] parts = rootName.Split(chars);
            string newRootName = "";
            foreach (var part in parts)
            {
                string newPart = Regex.Replace(part.ToUpper(), "[^a-zA-Z]", "");
                if (!string.IsNullOrWhiteSpace(part))
                {
                    if (newPart.Length > 1) newPart = newPart[0].ToString().ToUpper() + newPart.Substring(1, newPart.Length - 1).ToLower();
                    newRootName += newPart;
                }
            }
            return newRootName;
        }

        private void btnCreateRootName_Click(object sender, EventArgs e)
        {
            txtEnglishRoot.Text = ConvertRootName(txtEnglish.Text.Trim());
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtEnglish.Text = string.Empty;
            txtTurkish.Text = string.Empty;
            txtEnglishRoot.Text = string.Empty;
        }

        private void btnSaveTextFile_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("--- English Language XML ---");
                    sw.WriteLine();

                    foreach (DataGridViewRow dr in dgv.Rows)
                    {
                        sw.WriteLine(dr.Cells["English"].Value.ToString());
                    }

                    sw.WriteLine();
                    sw.WriteLine("--- Turkish Language XML ---");
                    sw.WriteLine();
                    foreach (DataGridViewRow dr in dgv.Rows)
                    {
                        sw.WriteLine(dr.Cells["Turkish"].Value.ToString());
                    }


                    sw.Close();

                }
            }
        }

        private void lnkBtnGithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo ps = new()
            {
                FileName = "https://github.com/demirburak/LanguageXMLHelper",
                UseShellExecute = true,
                Verb = "open"
            };

            Process.Start(ps);
        }
    }
}