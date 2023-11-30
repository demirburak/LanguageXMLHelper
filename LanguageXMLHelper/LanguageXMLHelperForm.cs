using System.Diagnostics;
using System.Text.RegularExpressions;

namespace LanguageXMLHelper
{
    public partial class LanguageXMLHelperForm : Form
    {
        string lineTypeDesc = "";
        Dictionary<string, string> ltcontents = new();
        List<ContentLine> contentLines = new();

        public LanguageXMLHelperForm()
        {
            InitializeComponent();

            DefineLineType();
            AddColumns();
            FillTheContents();
        }

        private void DefineLineType() => lineTypeDesc = (radioXML.Checked) ? "XML" : "JSON";

        private void FillTheContents()
        {
            ltcontents.Add("XML_Begin", "<text name=\"");
            ltcontents.Add("XML_Middle", "\">");
            ltcontents.Add("XML_End", "</text>");
            ltcontents.Add("JSON_Begin", "\"");
            ltcontents.Add("JSON_Middle", "\": \"");
            ltcontents.Add("JSON_End", "\"");
        }

        private string GetUuid()
        {
            string uuid;
            do
            {
                uuid = Guid.NewGuid().ToString("N");
            } while (contentLines.Any(x => x.Uuid == uuid));

            return uuid;
        }

        private void AddColumns()
        {
            dgv.Columns.Add("Id", "Id");
            dgv.Columns[dgv.Columns.Count-1].Visible = false;
            
            dgv.Columns.Add("Turkish", $"Turkish");
            dgv.Columns[dgv.Columns.Count - 1].Width = 300;

            dgv.Columns.Add("English", $"English");
            dgv.Columns[dgv.Columns.Count - 1].Width = 300;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEnglishRoot.Text)) ConvertRootName(txtEnglish.Text);
            InsertToDataGridView();
        }

        private void InsertToDataGridView()
        {
            string uuid, trText, enText, enRoot;
            trText = txtTurkish.Text = Clean(txtTurkish.Text);
            enText = txtEnglish.Text = Clean(txtEnglish.Text);
            enRoot = txtEnglishRoot.Text;
            uuid = GetUuid();

            if (string.IsNullOrWhiteSpace(trText) || string.IsNullOrWhiteSpace(enText) ||
                contentLines.Any(x => x.Content == trText || x.Content == enText))
            {
                return;
            }

            contentLines.Add(new ContentLine(uuid, "tr", enRoot, trText));
            contentLines.Add(new ContentLine(uuid, "en", enRoot, enText));
            dgv.Rows.Add(uuid, GetProcessedContent(enRoot, trText), GetProcessedContent(enRoot, enText));

        }

        private string GetProcessedContent(string root, string content)
        {
            return $"{ltcontents[$"{lineTypeDesc}_Begin"]}{root}{ltcontents[$"{lineTypeDesc}_Middle"]}{content}{ltcontents[$"{lineTypeDesc}_End"]}";
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
                string newPart = Regex.Replace(part.ToUpper().Replace("Ý","I"), "[^a-zA-Z]", "");
                if (!string.IsNullOrWhiteSpace(part))
                {
                    if (newPart.Length > 1) newPart = newPart[0].ToString() + newPart.Substring(1, newPart.Length - 1).ToLower().Replace("ý","i");
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
                    sw.WriteLine($"--- English Language {lineTypeDesc} ---");
                    sw.WriteLine();

                    foreach (DataGridViewRow dr in dgv.Rows)
                    {
                        sw.WriteLine(dr.Cells["English"].Value.ToString());
                    }

                    sw.WriteLine();
                    sw.WriteLine($"--- Turkish Language {lineTypeDesc} ---");
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

        private void radios_CheckedChanged(object sender, EventArgs e)
        {
            DefineLineType();
            FillDataGridViewFromList();
        }

        private void FillDataGridViewFromList()
        {
            dgv.Rows.Clear();
            List<string> uuids = contentLines.Select(x => x.Uuid).Distinct().ToList();

            foreach (var uuid in uuids)
            {
                ContentLine? trLine = contentLines.FirstOrDefault(x => x.Language == "tr" && x.Uuid == uuid);
                ContentLine? enLine = contentLines.FirstOrDefault(x => x.Language == "en" && x.Uuid == uuid);

                dgv.Rows.Add(uuid, GetProcessedContent(trLine.Root, trLine.Content), GetProcessedContent(enLine.Root, enLine.Content));
            }
        }

        private void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string uuid = e.Row.Cells["Id"].Value.ToString();
            contentLines.RemoveAll(x => x.Uuid == uuid);
        }
    }
}