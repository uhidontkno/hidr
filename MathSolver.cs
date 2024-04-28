using MaterialSkin;
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

namespace hidr
{
    public partial class MathSolver : Form
    {
        public MathSolver()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            this.BackColor = materialSkinManager.BackdropColor;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string operationStr = "";
            if (operation.SelectedIndex == 0)
            {
                operationStr = "solve";
            }
            else if (operation.SelectedIndex == 1)
            {
                operationStr = "simplify";
            }
            else if (operation.SelectedIndex == 2)
            {
                operationStr = "factor";
            }
            else {
                MessageBox.Show("Invalid operation.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (problem.Text.Trim().Length < 1)
            {
                MessageBox.Show("Type in a valid problem.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            output.Text = cabfiles.RunMathSolverCab(Path.Combine(Directory.GetCurrentDirectory(),"Resources/CAB0.cab"),operationStr+" "+problem.Text);
        }

        private void MathSolver_Load(object sender, EventArgs e)
        {

        }
    }
}
