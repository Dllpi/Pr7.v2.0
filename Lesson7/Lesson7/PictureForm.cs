using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class PictureEditor : Form
    {
        public Bitmap buffer;

        Graphics graphics;

        Color savedColor = Color.Black;

        public PictureEditor()
        {
            InitializeComponent();
        }

        private void picture_MouseMove(object sender, MouseEventArgs ev)
        {
            if (ev.Button != MouseButtons.Left)
            {
                return;
            }

            switch (MainForm.tool)
            {
                case 1:
                    graphics.DrawLine(MainForm.pen, ev.X, ev.Y, picture.Width / 2, picture.Height / 2);
                    break;
                case 2:
                    graphics.DrawRectangle(MainForm.pen, ev.X - 20, ev.Y - 20, 40, 40);
                    break;
                case 3:
                    graphics.DrawPolygon(MainForm.pen, new Point[] { new Point(ev.X, ev.Y - 20), new Point(ev.X + 20, ev.Y + 20), new Point(ev.X - 20, ev.Y + 20) });
                    break;

            }

            picture.Image = buffer;
        }

        private void picture_MouseClick(object sender, MouseEventArgs ev)
        {
            if (ev.Button == MouseButtons.Right)
            {
                graphics.Clear(Color.White);
                picture.Image = buffer;
            }
        }

        private void PictureEditor_Load(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(buffer);
            picture.Image = buffer;
        }

        private void PictureEditor_Activated(object sender, EventArgs e)
        {
            MainForm.pen.Color = savedColor;
        }

        private void PictureEditor_Deactivate(object sender, EventArgs e)
        {
            savedColor = MainForm.pen.Color;
        }
    }
}
