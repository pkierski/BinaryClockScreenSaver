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

        private BinaryClockDrawer drawer = new BinaryClockDrawer();

        public ScreenSaverForm()
        {
            InitializeComponent();
        }

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            drawer.CellSize = Math.Min(Bounds.Height, Bounds.Width) / 15.0f;
            this.Bounds = Bounds;
            updateClock();
        }

        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            drawer.CellSize = Math.Min(Bounds.Height, Bounds.Width) / 15.0f;
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

        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            updateClock();
        }

        private void updateClock()
        {
            this.Invalidate();
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

        private void ScreenSaverForm_Paint(object sender, PaintEventArgs e)
        {
            var panelSize = drawer.Size;
            var bitmap = new Bitmap(panelSize.Width + 1, panelSize.Height + 1);
            var bitmapGr = Graphics.FromImage(bitmap);
            bitmapGr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            bitmapGr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            drawer.Draw(bitmapGr, DateTime.Now);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImage(bitmap, new Point(10, 20));
        }
    }
}
