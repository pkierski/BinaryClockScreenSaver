﻿/*
 * SettingsForm.cs
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
using Microsoft.Win32;
using System.Security.Permissions;

namespace BinaryClockScreenSaver
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        /// <summary>
        /// Load display text from the Registry
        /// </summary>
        private void LoadSettings()
        {
            var key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo_ScreenSaver");
            if(key == null)
                textBox.Text = "C# Screen Saver";
            else
                textBox.Text = (string)key.GetValue("text");
        }

        /// <summary>
        /// Save text into the Registry.
        /// </summary>
        private void SaveSettings()
        {
            // Create or get existing subkey
            var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Demo_ScreenSaver");

            key.SetValue("text", textBox.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static Color getContrast(Color c)
        {
            var brightness = c.G * 0.59 + c.R * 0.3 + c.B * 0.11;
            return brightness > 128 ? Color.Black : Color.White;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var button = sender as ColorPickerButton;
            if(button == null)
                return;

            colorDialog.Color = button.Color;
            if(colorDialog.ShowDialog() == DialogResult.OK)
                button.Color = colorDialog.Color;
        }
    }
}
