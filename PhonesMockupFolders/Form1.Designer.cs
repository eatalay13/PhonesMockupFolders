namespace PhonesMockupFolders
{
    partial class Form1
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
            this.PathFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.PhoneFolderBtn = new System.Windows.Forms.Button();
            this.finalCaseFolderBtn = new System.Windows.Forms.Button();
            this.copyFolderBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newPhoneNameTbx = new System.Windows.Forms.TextBox();
            this.newFinalCaseNameTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneFolderBtn
            // 
            this.PhoneFolderBtn.Location = new System.Drawing.Point(12, 12);
            this.PhoneFolderBtn.Name = "PhoneFolderBtn";
            this.PhoneFolderBtn.Size = new System.Drawing.Size(74, 44);
            this.PhoneFolderBtn.TabIndex = 0;
            this.PhoneFolderBtn.Tag = "phone";
            this.PhoneFolderBtn.Text = "Telefonlar Klasörü";
            this.PhoneFolderBtn.UseVisualStyleBackColor = true;
            this.PhoneFolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // finalCaseFolderBtn
            // 
            this.finalCaseFolderBtn.Location = new System.Drawing.Point(92, 12);
            this.finalCaseFolderBtn.Name = "finalCaseFolderBtn";
            this.finalCaseFolderBtn.Size = new System.Drawing.Size(74, 44);
            this.finalCaseFolderBtn.TabIndex = 1;
            this.finalCaseFolderBtn.Tag = "finalCase";
            this.finalCaseFolderBtn.Text = "En üst Kılıf Klasörü";
            this.finalCaseFolderBtn.UseVisualStyleBackColor = true;
            this.finalCaseFolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // copyFolderBtn
            // 
            this.copyFolderBtn.Location = new System.Drawing.Point(172, 12);
            this.copyFolderBtn.Name = "copyFolderBtn";
            this.copyFolderBtn.Size = new System.Drawing.Size(97, 44);
            this.copyFolderBtn.TabIndex = 2;
            this.copyFolderBtn.Tag = "copy";
            this.copyFolderBtn.Text = "Kopyalanacak Klasör";
            this.copyFolderBtn.UseVisualStyleBackColor = true;
            this.copyFolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 44);
            this.button1.TabIndex = 3;
            this.button1.Tag = "phone";
            this.button1.Text = "Kopyala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telefon Layer Adı";
            // 
            // newPhoneNameTbx
            // 
            this.newPhoneNameTbx.Location = new System.Drawing.Point(15, 105);
            this.newPhoneNameTbx.Name = "newPhoneNameTbx";
            this.newPhoneNameTbx.Size = new System.Drawing.Size(100, 20);
            this.newPhoneNameTbx.TabIndex = 5;
            this.newPhoneNameTbx.TextChanged += new System.EventHandler(this.NewPhoneNameTbx_TextChanged);
            // 
            // newFinalCaseNameTbx
            // 
            this.newFinalCaseNameTbx.Location = new System.Drawing.Point(132, 105);
            this.newFinalCaseNameTbx.Name = "newFinalCaseNameTbx";
            this.newFinalCaseNameTbx.Size = new System.Drawing.Size(100, 20);
            this.newFinalCaseNameTbx.TabIndex = 7;
            this.newFinalCaseNameTbx.TextChanged += new System.EventHandler(this.NewFinalCaseNameTbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mockup Layer Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 482);
            this.Controls.Add(this.newFinalCaseNameTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPhoneNameTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copyFolderBtn);
            this.Controls.Add(this.finalCaseFolderBtn);
            this.Controls.Add(this.PhoneFolderBtn);
            this.Name = "Form1";
            this.Text = "Mockup Klasörleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog PathFBD;
        private System.Windows.Forms.Button PhoneFolderBtn;
        private System.Windows.Forms.Button finalCaseFolderBtn;
        private System.Windows.Forms.Button copyFolderBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPhoneNameTbx;
        private System.Windows.Forms.TextBox newFinalCaseNameTbx;
        private System.Windows.Forms.Label label2;
    }
}

