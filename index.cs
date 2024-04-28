using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace hidr
{
    public partial class index : MaterialForm
    {
        public index()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.WHITE);
            
        }
        // Size formsize = new index().Size;
        private void index_Load(object sender, EventArgs e)
        {
            
            Size formsize = this.Size;
            formsize.Height = formsize.Height - 67;
            this.MaximumSize = formsize;
            this.MinimumSize = formsize;
          

        }


        private void themeBtn_Click(object sender, EventArgs e)
        {

        }

        private void materialDrawer1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Layout(object sender, LayoutEventArgs e)
        {
            if (tabs.SelectedTab == tabPage2) {
                new themeSelector().ShowDialog();
                tabs.SelectTab(0);
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new skoolcleanup().Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void index_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void index_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
