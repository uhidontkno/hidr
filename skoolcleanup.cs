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

        private void skoolcleanup_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
