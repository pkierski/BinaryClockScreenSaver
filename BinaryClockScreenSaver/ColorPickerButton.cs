using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryClockScreenSaver
{
    public partial class ColorPickerButton : System.Windows.Forms.Button
    {
        public ColorPickerButton()
        {
            InitializeComponent();
        }

        [Category("Apperance"), Description("Selected color")]
        public Color Color
        {
            get
            {
                return BackColor;
            }

            set
            {
                BackColor = value;
                ForeColor = getContrast(value);
            }
        }

        private static Color getContrast(Color c)
        {
            var brightness = c.G * 0.59 + c.R * 0.3 + c.B * 0.11;
            return brightness > 128 ? Color.Black : Color.White;
        }

        
    }
}
