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
        static bool solved = false;
        static int time = 0;
        async private void materialButton1_Click(object sender, EventArgs e)
        {
            solved = false; time = 0;
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
           
            
            output.Text = "Solving...";
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            Task.Run(async () =>
            {
                
                while (solved == false)
                {

                    await Task.Delay(39);
                    time = time + 39;
                    if (!solved)
                    {
                        Invoke((Action)(() =>
                        {
                            output.Text = $"Solving... ({time}ms)";
                        }));
                    }
                    else { break;  }
                }
            });
            Random r = new Random();
            await Task.Delay(39);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            if (operation.SelectedIndex != 0)
            {
                await Task.Run(async () =>
                {
                    string result = await cabfiles.RunMathSolverCab(Path.Combine(Directory.GetCurrentDirectory(), "Resources/CAB0.cab"), operationStr + " \"" + problem.Text + "\"");
                    solved = true;
                    Invoke((Action)(() =>
                    {
                        output.Text = result + $"\nTook {(float)time / 1000}s";
                    }));
                    time = 0;
                });
            } else
            {
                try
                {
                    solved = true;
                    await Task.Delay(39);
                    double result = EvaluateExpression(problem.Text);
                    output.Text = $"Problem: {problem.Text}\r\nSolution: {result}\r\n\r\nTook {(float)time}ms";
                }
                catch (Exception ex) {
                    solved = true;
                    await Task.Delay(39);
                    output.Text = $"Error: {ex.Message}\r\n\r\nTook {(float)time}ms";
                    
                }
            }
            
        }
        static double EvaluateExpression(string expression)
        {
            DataTable dt = new DataTable();
            object result = dt.Compute(expression, "");

            return Convert.ToDouble(result);
        }

        private void MathSolver_Load(object sender, EventArgs e)
        {

        }
    }
}
