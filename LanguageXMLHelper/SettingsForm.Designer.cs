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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Prefix";
            // 
            // txtPrefix
            // 
            txtPrefix.Location = new Point(12, 36);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(193, 27);
            txtPrefix.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Suffix";
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(12, 103);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(193, 27);
            txtSuffix.TabIndex = 6;
            // 
            // chcHasTranslate
            // 
            chcHasTranslate.AutoSize = true;
            chcHasTranslate.Location = new Point(14, 152);
            chcHasTranslate.Name = "chcHasTranslate";
            chcHasTranslate.Size = new Size(130, 24);
            chcHasTranslate.TabIndex = 8;
            chcHasTranslate.Text = "Has Translate ?";
            chcHasTranslate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(111, 221);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(224, 272);
            Controls.Add(btnClose);
            Controls.Add(chcHasTranslate);
            Controls.Add(label2);
            Controls.Add(txtSuffix);
            Controls.Add(label1);
            Controls.Add(txtPrefix);
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrefix;
        private Label label2;
        private TextBox txtSuffix;
        private CheckBox chcHasTranslate;
        private Button btnClose;
    }
}