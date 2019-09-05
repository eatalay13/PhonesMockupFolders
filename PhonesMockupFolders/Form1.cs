using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonesMockupFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string PhonesFolderPath { get; set; }
        public string FinalCaseFolderPath { get; set; }
        public string CopyFolderPath { get; set; }

        public string NewPhoneFileName { get; set; }
        public string NewFinalCaseName { get; set; }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            PathFBD.ShowDialog();

            switch (btn.Tag)
            {
                case "phone":
                    PhonesFolderPath = PathFBD.SelectedPath;
                    break;

                case "finalCase":
                    FinalCaseFolderPath = PathFBD.SelectedPath;
                    break;

                case "copy":
                    CopyFolderPath = PathFBD.SelectedPath;
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(PhonesFolderPath, "*.png");

            int startIndex = PhonesFolderPath.Length + 1;

            foreach (var file in files)
            {
                int stopIndex = file.IndexOf('.');
                int lenght = stopIndex - startIndex;

                var fileName = file.Substring(startIndex, lenght);

                var fileNewPath = CopyFolderPath + "\\" + fileName.Trim().Replace("-", "");

                if (!Directory.Exists(fileNewPath))
                    Directory.CreateDirectory(fileNewPath);

                File.Copy(file, fileNewPath + $"\\{NewPhoneFileName}.png");
                try
                {
                    File.Copy(FinalCaseFolderPath + $"\\{fileName.Replace("-"," ")}.png", fileNewPath + $"\\{NewFinalCaseName}.png");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void NewPhoneNameTbx_TextChanged(object sender, EventArgs e)
        {
            NewPhoneFileName = ((TextBox)sender).Text;
        }

        private void NewFinalCaseNameTbx_TextChanged(object sender, EventArgs e)
        {
            NewFinalCaseName = ((TextBox)sender).Text;
        }
    }
}
