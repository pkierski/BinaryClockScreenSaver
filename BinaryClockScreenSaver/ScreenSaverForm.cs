/*
 * ScreenSaverForm.cs
 * By Frank McCown
 * Summer 2010
 * 
 * Feel free to modify this code.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace BinaryClockScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        #region Win32 API functions

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        #endregion


        private Point mouseLocation;
        private bool previewMode;
        private Random rand = new Random();
        private int shitfX = 10;
        private int shitfY = 10;

        public ScreenSaverForm()
        {
            InitializeComponent();
        }

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
            binaryClockPanel.Location = new Point(rand.Next(Bounds.Right), rand.Next(Bounds.Bottom));
            updateClock();
        }

        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            // Make text smaller
            // textLabel.Font = new System.Drawing.Font("Arial", 6);

            previewMode = true;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            LoadSettings();

            Cursor.Hide();
            TopMost = true;

            moveTimer.Interval = 1000;
            moveTimer.Tick += moveTimer_Tick;
            moveTimer.Start();
        }

        private void setupRow(Label[] labels, int x)
        {
            for(int i = 0; i < labels.Length; ++i)
            {
                if((x % 2) != 0)
                {
                    labels[i].Text = "⚫";
                    labels[i].ForeColor = Color.Red;
                }
                else
                {
                    labels[i].Text = "⚫";
                    labels[i].ForeColor = Color.FromArgb(32, 0, 0);
                }
                x /= 2;
            }
        }

        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            updateClock();
        }

        private void updateClock()
        {
            // Move to new location
            //binaryClockPanel.Left = rand.Next(Math.Max(1, Bounds.Width - binaryClockPanel.Width));
            //binaryClockPanel.Top = rand.Next(Math.Max(1, Bounds.Height - binaryClockPanel.Height));
            binaryClockPanel.Left += shitfX;
            binaryClockPanel.Top += shitfY;
            if(binaryClockPanel.Right >= Bounds.Width || binaryClockPanel.Left <= 0)
                shitfX = -shitfX;
            if(binaryClockPanel.Bottom >= Bounds.Height || binaryClockPanel.Top <= 0)
                shitfY = -shitfY;

            // update display
            var now = DateTime.Now;
            var hourLabels = new Label[] { labelH1, labelH2, labelH4, labelH8, labelH16 };
            setupRow(hourLabels, now.Hour);
            var minuteLabels = new Label[] { labelM1, labelM2, labelM4, labelM8, labelM16, labelM32 };
            setupRow(minuteLabels, now.Minute);
            var secondLabels = new Label[] { labelS1, labelS2, labelS4, labelS8, labelS16, labelS32 };
            setupRow(secondLabels, now.Second);
        }

        private void LoadSettings()
        {
            // Use the string from the Registry if it exists
            var key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo_ScreenSaver");
            //if(key == null)
            //    textLabel.Text = "C# Screen Saver";
            //else
            //    textLabel.Text = (string)key.GetValue("text");
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(!previewMode)
            {
                if(!mouseLocation.IsEmpty)
                {
                    // Terminate if mouse is moved a significant distance
                    if(Math.Abs(mouseLocation.X - e.X) > 5 ||
                        Math.Abs(mouseLocation.Y - e.Y) > 5)
                        Application.Exit();
                }

                // Update current mouse location
                mouseLocation = e.Location;
            }
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!previewMode)
                Application.Exit();
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(!previewMode)
                Application.Exit();
        }
    }
}
