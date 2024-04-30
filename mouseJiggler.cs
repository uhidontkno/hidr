using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidr
{
    public partial class mouseJiggler : Form
    {
        public mouseJiggler()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            this.BackColor = materialSkinManager.BackdropColor;
        }
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out int X, out int Y);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        const uint MOUSEEVENTF_LEFTUP = 0x04;
        public static void SimulateMouseClick()
        {
            int x, y;
            GetCursorPos(out x, out y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        const int KEYEVENTF_KEYDOWN = 0x0001;
        const int KEYEVENTF_KEYUP = 0x0002;
        public static void SimulateKeyPress(Keys key)
        {
            byte keyCode = (byte)key;
            keybd_event(keyCode, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
            Thread.Sleep(50);
            keybd_event(keyCode, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }
        public static Keys GetRandomKey()
        {
            Random rand = new Random();
            Keys[] keysArray = {
            Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F, Keys.G, Keys.H, Keys.I, Keys.J,
            Keys.K, Keys.L, Keys.M, Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T,
            Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y, Keys.Z,
            Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9
        };

            int index = rand.Next(0, keysArray.Length);
            return keysArray[index];
        }
        async public static Task startJigglingMouse(bool randClick, bool randKey)
        {
            int centerX = Screen.PrimaryScreen.Bounds.Width / 2;
            int centerY = Screen.PrimaryScreen.Bounds.Height / 2;

            Random rand = new Random();
            int smoothness = 25;
            int delay = 12;

            while (!index.Keyboard.IsKeyDown(Keys.F7))
            {
                
                int destinationX = centerX + rand.Next(-240, 240);
                int destinationY = centerY + rand.Next(-75, 75);

                int currentX, currentY;
                GetCursorPos(out currentX, out currentY);

                for (int i = 1; i <= smoothness; i++)
                {
                   
                    int newX = currentX + (destinationX - currentX) * i / smoothness;
                    int newY = currentY + (destinationY - currentY) * i / smoothness;

                    SetCursorPos(newX, newY);

                    await Task.Delay(delay);
                }
                if (randClick) {
                    SimulateMouseClick();
                    await Task.Delay(500);
                }
                if (randKey)
                {
                    
                        SimulateKeyPress(GetRandomKey());
                    await Task.Delay(500);
                }
                await Task.Delay(500);
            }
            SetCursorPos(centerX,centerY);

        }
        private void mouseJiggler_Load(object sender, EventArgs e)
        {
            this.Size = new Size(342, 358);
        }

        async private void jiggleButton_Click(object sender, EventArgs e)
        {
            Size pastSize = this.Size;
            Form form = jiggleButton.FindForm();
            jiggleButton.Enabled = false;
            jiggleButton.Text = "Hold F7 down to stop.";
            title.Visible = false;
            form.Size = new Size(235, 86+18);
            card.Visible = true;
            await startJigglingMouse(clickSwitch.Checked,keyPressSwitch.Checked);
            int centerX = Screen.PrimaryScreen.Bounds.Width / 2;
            int centerY = Screen.PrimaryScreen.Bounds.Height / 2;
            SetCursorPos(centerX, centerY);
            jiggleButton.Enabled = true;
            jiggleButton.Text = "Start Jiggling";
            title.Visible = true;
            form.Size = pastSize;
            card.Visible = false;

        }
    }
}
