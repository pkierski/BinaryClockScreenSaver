using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClockScreenSaver
{
    class BinaryClockDrawer
    {
        public BinaryClockDrawer()
        {
            InactiveColor = Color.FromArgb(48, 16, 16);
            ActiveColor = Color.Red;
            BackgroundColor = Color.FromArgb(20, 20, 20);
        }

        public float CellSize = 50.0f;
        public float LampFill = 0.75f;

        public Color ActiveColor
        {
            get
            {
                return activeColorBrush.Color;
            }
            set
            {
                activeColorBrush = new SolidBrush(value);
            }
        }
        private SolidBrush activeColorBrush = null;

        public Color InactiveColor
        {
            get
            {
                return inactiveColorBrush.Color;
            }
            set
            {
                inactiveColorBrush = new SolidBrush(value);
            }
        }
        private SolidBrush inactiveColorBrush = null;

        public Color BackgroundColor
        {
            get
            {
                return backgroundColorBrush.Color;
            }
            set
            {
                backgroundColorBrush = new SolidBrush(value);
            }
        }
        private SolidBrush backgroundColorBrush = null;

        public bool DrawSeconds = true;
        public PointF Location = new PointF(0, 0);
        public SizeF SizeF
        {
            get
            {
                return new SizeF(6 * CellSize, (DrawSeconds ? 3 : 2) * CellSize);
            }
        }

        public Size Size
        {
            get
            {
                return SizeF.ToSize();
            }
        }

        public void Draw(Graphics graphics, DateTime time)
        {
            graphics.FillRectangle(backgroundColorBrush, new RectangleF(Location, SizeF));

            var hour = time.Hour;
            drawCell(graphics, 1, 0, (hour & 16) != 0);
            drawCell(graphics, 2, 0, (hour & 8) != 0);
            drawCell(graphics, 3, 0, (hour & 4) != 0);
            drawCell(graphics, 4, 0, (hour & 2) != 0);
            drawCell(graphics, 5, 0, (hour & 1) != 0);

            var minute = time.Minute;
            drawCell(graphics, 0, 1, (minute & 32) != 0);
            drawCell(graphics, 1, 1, (minute & 16) != 0);
            drawCell(graphics, 2, 1, (minute & 8) != 0);
            drawCell(graphics, 3, 1, (minute & 4) != 0);
            drawCell(graphics, 4, 1, (minute & 2) != 0);
            drawCell(graphics, 5, 1, (minute & 1) != 0);

            if(DrawSeconds)
            {
                var second = time.Second;
                drawCell(graphics, 0, 2, (second & 32) != 0);
                drawCell(graphics, 1, 2, (second & 16) != 0);
                drawCell(graphics, 2, 2, (second & 8) != 0);
                drawCell(graphics, 3, 2, (second & 4) != 0);
                drawCell(graphics, 4, 2, (second & 2) != 0);
                drawCell(graphics, 5, 2, (second & 1) != 0);
            }
        }

        void drawCell(Graphics graphics, int x, int y, bool active)
        {
            var left = x * CellSize + CellSize * (1 - LampFill) / 2;
            var top = y * CellSize + CellSize * (1 - LampFill) / 2;
            var ellipseRect = new RectangleF(new PointF(left, top), new SizeF(CellSize * LampFill, CellSize * LampFill));
            ellipseRect.Offset(Location);
            graphics.FillEllipse(active ? activeColorBrush : inactiveColorBrush, ellipseRect);
        }
    }
}
