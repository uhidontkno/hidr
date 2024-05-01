using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidr
{
    public partial class cmdbypass : Form
    {
        public static void ExtractFile(object resource, string targetPath, bool binary)
        {

            if (binary == true && resource is byte[] bin)
            {
                File.WriteAllBytes(targetPath, bin);
            }
            else if (binary == false && resource is string str)
            {
                File.WriteAllText(targetPath, str);
            }
            else
            {
                throw new ArgumentException("Invalid argument for resource recieved.");
            }
        }
        public static string GetRandomFP(string extension = "", string directory = null)
        {
            if (directory == null)
            {
                directory = Path.GetTempPath();
            }
            else if (!Directory.Exists(directory))
            {
                throw new DirectoryNotFoundException("Directory does not exist.");
            }

            string fileName;
            if (string.IsNullOrWhiteSpace(extension))
            {
                fileName = Path.Combine(directory, $"{Guid.NewGuid().ToString()}");
            }
            else
            {
                fileName = Path.Combine(directory, $"{Guid.NewGuid().ToString()}.{extension.TrimStart('.')}");
            }

            return fileName.ToString();
        }
        public cmdbypass()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            this.BackColor = materialSkinManager.BackdropColor;
        }

        private void cmdbypass_Load(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:/Transcripts")) {
                MessageBox.Show("Your device admin might be able to see what commands you run!","Beware",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Process.Start("powershell");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var fp = GetRandomFP(".bat");
            ExtractFile(Properties.Resources.cbm1,fp,false);
            Process.Start(fp);
        }
    }
}
