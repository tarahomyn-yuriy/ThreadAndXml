namespace WinFormsApp2
{
    partial class Form1
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
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDownloadExCurr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxInfo.Location = new System.Drawing.Point(8, 41);
            this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(787, 486);
            this.richTextBoxInfo.TabIndex = 2;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(285, 4);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 31);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Зупинити";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDownloadExCurr
            // 
            this.buttonDownloadExCurr.Location = new System.Drawing.Point(8, 4);
            this.buttonDownloadExCurr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDownloadExCurr.Name = "buttonDownloadExCurr";
            this.buttonDownloadExCurr.Size = new System.Drawing.Size(106, 31);
            this.buttonDownloadExCurr.TabIndex = 3;
            this.buttonDownloadExCurr.Text = "Завантажити";
            this.buttonDownloadExCurr.UseVisualStyleBackColor = true;
            this.buttonDownloadExCurr.Click += new System.EventHandler(this.buttonDownloadExCurr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 539);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDownloadExCurr);
            this.Controls.Add(this.richTextBoxInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxInfo;
        private Button buttonCancel;
        private Button buttonDownloadExCurr;
    }
}