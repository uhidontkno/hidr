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
    }
}
