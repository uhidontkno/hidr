using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Diagnostics;
namespace hidr
{
    public partial class skoolcleanup : Form
    {
        public skoolcleanup()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            this.BackColor = materialSkinManager.BackdropColor;
        }
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
            else {
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
        private void skoolcleanup_Load(object sender, EventArgs e)
        {

        }

        async private void materialButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The script will ask you for admin, but you don't need actual admin. Put in your credentials anyway.","Tip",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string fp = GetRandomFP(".cmd");
            ExtractFile(Properties.Resources.kak12, fp, false);
            Process process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = "/c " + fp;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
            this.Close();
            await Task.Delay(1000);
            MessageBox.Show("Successfully started! Wait a few seconds and it should be gone.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        async private void materialButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The script will ask you for admin, but you don't need actual admin. Put in your credentials anyway.\nAlso, your teacher may be able to know that you've killed Lightspeed Classroom.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string fp = GetRandomFP(".cmd");
            ExtractFile(Properties.Resources.klsc, fp, false);
            Process process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = "/c "+fp;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
            this.Close();
            await Task.Delay(1000);
            MessageBox.Show("Successfully started! Wait a few seconds and it should be gone.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
