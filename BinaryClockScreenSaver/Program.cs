/*
 * Program.cs
 * By Frank McCown
 * Summer 2010
 * 
 * Feel free to modify this code.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BinaryClockScreenSaver
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args.Length > 0)
            {
                var firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon. 
                // Examples: /c:1234567 or /P:1234567
                if(firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if(args.Length > 1)
                    secondArgument = args[1];
                switch(firstArgument)
                {
                case "/c":
                    Application.Run(new SettingsForm());
                    break;
                case "/p":
                    if(secondArgument == null)
                    {
                        MessageBox.Show("Sorry, but the expected window handle was not provided.",
                            "ScreenSaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    var previewWndHandle = new IntPtr(long.Parse(secondArgument));
                    Application.Run(new ScreenSaverForm(previewWndHandle));
                    break;
                case "/s":
                    ShowScreenSaver();
                    Application.Run();
                    break;
                default:
                    MessageBox.Show("Sorry, but the command line argument \"" + firstArgument +
          "\" is not valid.", "ScreenSaver",
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
            }
            else    // No arguments - treat like /c
            {
                Application.Run(new SettingsForm());
            }
        }

        /// <summary>
        /// Display the form on each of the computer's monitors.
        /// </summary>
        static void ShowScreenSaver()
        {
            foreach(Screen screen in Screen.AllScreens)
            {
                var screensaver = new ScreenSaverForm(screen.Bounds);
                screensaver.Show();
            }
        }
    }
}
