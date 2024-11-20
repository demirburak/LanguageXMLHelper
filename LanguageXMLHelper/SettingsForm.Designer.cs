namespace LanguageXMLHelper
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPrefix = new TextBox();
            label2 = new Label();
            txtSuffix = new TextBox();
            chcHasTranslate = new CheckBox();
            btnClose = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            txtTranslationUrl = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Prefix";
            // 
            // txtPrefix
            // 
            txtPrefix.Location = new Point(4, 25);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(193, 27);
            txtPrefix.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Suffix";
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(4, 92);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(193, 27);
            txtSuffix.TabIndex = 6;
            // 
            // chcHasTranslate
            // 
            chcHasTranslate.AutoSize = true;
            chcHasTranslate.Location = new Point(8, 243);
            chcHasTranslate.Name = "chcHasTranslate";
            chcHasTranslate.Size = new Size(130, 24);
            chcHasTranslate.TabIndex = 8;
            chcHasTranslate.Text = "Has Translate ?";
            chcHasTranslate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(366, 312);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(472, 306);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtTranslationUrl);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtPrefix);
            tabPage1.Controls.Add(chcHasTranslate);
            tabPage1.Controls.Add(txtSuffix);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(464, 273);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 152);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "Translation Url";
            // 
            // txtTranslationUrl
            // 
            txtTranslationUrl.Location = new Point(6, 174);
            txtTranslationUrl.Name = "txtTranslationUrl";
            txtTranslationUrl.Size = new Size(450, 27);
            txtTranslationUrl.TabIndex = 6;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(472, 353);
            Controls.Add(tabControl1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            Load += SettingsForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtPrefix;
        private Label label2;
        private TextBox txtSuffix;
        private CheckBox chcHasTranslate;
        private Button btnClose;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private TextBox txtTranslationUrl;
    }
}