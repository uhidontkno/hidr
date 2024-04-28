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
    public partial class themeSelector : MaterialForm
    {
        public themeSelector()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
           
        }

        private void themeSelector_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
                if (materialSkinManager.Theme == MaterialSkinManager.Themes.LIGHT) {
                materialSwitch1.Checked = false;
            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            if (materialSwitch1.Checked == true)
            { materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; } else
            { materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; }
            
        }
    }
}
