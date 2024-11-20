namespace LanguageXMLHelper
{
    partial class LanguageXMLHelperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageXMLHelperForm));
            panel1 = new Panel();
            btnTranslate = new Button();
            btnSettings = new Button();
            radioJson = new RadioButton();
            radioXML = new RadioButton();
            btnSaveTextFile = new Button();
            btnClean = new Button();
            btnCreateRootName = new Button();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEnglish = new TextBox();
            txtTurkish = new TextBox();
            txtEnglishRoot = new TextBox();
            panel2 = new Panel();
            lnkBtnGithubLink = new LinkLabel();
            dgv = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTranslate);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(radioJson);
            panel1.Controls.Add(radioXML);
            panel1.Controls.Add(btnSaveTextFile);
            panel1.Controls.Add(btnClean);
            panel1.Controls.Add(btnCreateRootName);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEnglish);
            panel1.Controls.Add(txtTurkish);
            panel1.Controls.Add(txtEnglishRoot);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 276);
            panel1.TabIndex = 0;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(680, 69);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(174, 29);
            btnTranslate.TabIndex = 10;
            btnTranslate.Text = "Translation Shortcut";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Visible = false;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(877, 29);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(119, 29);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // radioJson
            // 
            radioJson.AutoSize = true;
            radioJson.Location = new Point(12, 246);
            radioJson.Name = "radioJson";
            radioJson.Size = new Size(96, 24);
            radioJson.TabIndex = 8;
            radioJson.Text = "JSON Line";
            radioJson.UseVisualStyleBackColor = true;
            radioJson.CheckedChanged += radios_CheckedChanged;
            // 
            // radioXML
            // 
            radioXML.AutoSize = true;
            radioXML.Checked = true;
            radioXML.Location = new Point(12, 217);
            radioXML.Name = "radioXML";
            radioXML.Size = new Size(90, 24);
            radioXML.TabIndex = 7;
            radioXML.TabStop = true;
            radioXML.Text = "XML Line";
            radioXML.UseVisualStyleBackColor = true;
            radioXML.CheckedChanged += radios_CheckedChanged;
            // 
            // btnSaveTextFile
            // 
            btnSaveTextFile.Location = new Point(877, 220);
            btnSaveTextFile.Name = "btnSaveTextFile";
            btnSaveTextFile.Size = new Size(119, 50);
            btnSaveTextFile.TabIndex = 6;
            btnSaveTextFile.Text = "Save Text File";
            btnSaveTextFile.UseVisualStyleBackColor = true;
            btnSaveTextFile.Click += btnSaveTextFile_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(877, 69);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(119, 29);
            btnClean.TabIndex = 3;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnCreateRootName
            // 
            btnCreateRootName.Location = new Point(877, 107);
            btnCreateRootName.Name = "btnCreateRootName";
            btnCreateRootName.Size = new Size(119, 50);
            btnCreateRootName.TabIndex = 5;
            btnCreateRootName.Text = "Create Root Name";
            btnCreateRootName.UseVisualStyleBackColor = true;
            btnCreateRootName.Click += btnCreateRootName_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(877, 163);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 152);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 5;
            label3.Text = "English Root XML Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 78);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "English";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Turkish";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(12, 101);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(842, 27);
            txtEnglish.TabIndex = 1;
            // 
            // txtTurkish
            // 
            txtTurkish.Location = new Point(12, 36);
            txtTurkish.Name = "txtTurkish";
            txtTurkish.Size = new Size(842, 27);
            txtTurkish.TabIndex = 0;
            // 
            // txtEnglishRoot
            // 
            txtEnglishRoot.BackColor = Color.LemonChiffon;
            txtEnglishRoot.Location = new Point(12, 175);
            txtEnglishRoot.Name = "txtEnglishRoot";
            txtEnglishRoot.Size = new Size(842, 27);
            txtEnglishRoot.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(lnkBtnGithubLink);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 30);
            panel2.TabIndex = 1;
            // 
            // lnkBtnGithubLink
            // 
            lnkBtnGithubLink.AutoSize = true;
            lnkBtnGithubLink.Location = new Point(3, 3);
            lnkBtnGithubLink.Name = "lnkBtnGithubLink";
            lnkBtnGithubLink.Size = new Size(93, 20);
            lnkBtnGithubLink.TabIndex = 9;
            lnkBtnGithubLink.TabStop = true;
            lnkBtnGithubLink.Text = "[Github Link]";
            lnkBtnGithubLink.LinkClicked += lnkBtnGithubLink_LinkClicked;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 0);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1008, 361);
            dgv.TabIndex = 6;
            dgv.UserDeletingRow += dgv_UserDeletingRow;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "LanguageConverter.txt";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 361);
            panel3.TabIndex = 2;
            // 
            // LanguageXMLHelperForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 667);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LanguageXMLHelperForm";
            Text = "Language XML Helper";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEnglish;
        private TextBox txtTurkish;
        private TextBox txtEnglishRoot;
        private Panel panel2;
        private DataGridView dgv;
        private Button btnAdd;
        private Button btnCreateRootName;
        private Button btnClean;
        private Button btnSaveTextFile;
        private SaveFileDialog saveFileDialog1;
        private Panel panel3;
        private LinkLabel lnkBtnGithubLink;
        private RadioButton radioJson;
        private RadioButton radioXML;
        private Button btnSettings;
        private Button btnTranslate;
    }
}