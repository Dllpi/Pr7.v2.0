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
    public partial class MainForm : Form
    {
        public static Pen pen = new Pen(Color.Black, 1);

        int countPicture = 0;

        public static int tool = 1;

        public MainForm()
        {
            InitializeComponent();

            menuGeneral.MdiWindowListItem = menuWindow;
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            pen.Color = colorDialog.Color;
        }

        private void menuNewPicture_Click(object sender, EventArgs e)
        {
            countPicture++;

            PictureEditor childForm = new PictureEditor
            {
                MdiParent = this,
                Text = "Рисунок#" + countPicture.ToString(),
                buffer = new Bitmap(1280, 720)
            };

            childForm.Show();
        }

        private void menuOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            Image pic = Image.FromFile(openFileDialog1.FileName);

            float k = 1;

            if (pic.Width >= pic.Height && pic.Width > 1280)
            {
                k = 1270f / pic.Width;
            }
            else if (pic.Width < pic.Height && pic.Height > 720)
            {
                k = 720f / pic.Height;
            }

            PictureEditor childForm = new PictureEditor
            {
                MdiParent = this,
                Text = openFileDialog1.FileName,
                buffer = new Bitmap(pic, (int)(pic.Width * k), (int)(pic.Height * k))
            };

            childForm.Show();
        }

        private void menuSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            PictureEditor X = (PictureEditor)ActiveMdiChild;

            X.buffer.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);

            ActiveMdiChild.Text = saveFileDialog1.FileName;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tool = 1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tool = 2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tool = 3;
        }

        private void menuCascad_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
