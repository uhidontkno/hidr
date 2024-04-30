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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue200, Accent.Blue200, TextShade.WHITE);
            
        }
        static bool vanished = false;
       
        async private void index_Load(object sender, EventArgs e)
        {

            this.Size = new Size(349, 418);
            this.Tag = "mainWindow";
            while (true) {
                await Task.Delay(100);
                if (Keyboard.IsKeyDown(Keys.F4)) {
                    if (vanished == true)
                    {
                        vanished = false; this.Show();
                        foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                        {
                            form.Show();
                        }
                    }
                    else {
                        vanished = true; this.Hide();
                        foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                        {
                                form.Hide();
                            
                        }
                    }
                }
            }

        }



        public abstract class Keyboard
        {
            [Flags]
            private enum KeyStates
            {
                None = 0,
                Down = 1,
                Toggled = 2
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            private static extern short GetKeyState(int keyCode);

            private static KeyStates GetKeyState(Keys key)
            {
                KeyStates state = KeyStates.None;

                short retVal = GetKeyState((int)key);

                //If the high-order bit is 1, the key is down
                //otherwise, it is up.
                if ((retVal & 0x8000) == 0x8000)
                    state |= KeyStates.Down;

                //If the low-order bit is 1, the key is toggled.
                if ((retVal & 1) == 1)
                    state |= KeyStates.Toggled;

                return state;
            }

            public static bool IsKeyDown(Keys key)
            {
                return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
            }

            public static bool IsKeyToggled(Keys key)
            {
                return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
            }
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
            new skoolcleanup().ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press F4 to respawn me. (Use the F4 keybind to bypass this message)","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            vanished = true; this.Hide();
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form.Tag?.ToString() != "mainWindow")
                {
                    form.Hide();
                }
            }
        }

        private void index_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void index_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            new MathSolver().ShowDialog();
        }
    }
}
