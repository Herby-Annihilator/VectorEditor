using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

// Он тут самый главный

namespace GraphicsEditor2
{
    public class Painter
    {
        private Geometry geometry;
        private PictureBox pictureBox;
        private PictureBox mainPictureBox;

        private ToolStripContentPanel mainPictureBoxParent;
        private Size mainPictureBoxSize;



        public Painter()
        {
            geometry = null;
            pictureBox = null;
            mainPictureBox = null;
            mainPictureBoxParent = null;
            mainPictureBoxSize.Width = 0;
            mainPictureBoxSize.Height = 0;
        }
        public Painter(ref ToolStripContentPanel parent, Size size)
        {
           
        }
        public void ChooseGeometry(Geometry geometry)
        {
            this.geometry = geometry;
        }

        public PictureBox CreateNewPictureBox()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Parent = mainPictureBox;
            pictureBox.BackColor = Color.Transparent;
            return pictureBox;
        }
        private void CreateMainPictureBox(ref ToolStripContentPanel parent, Size size)
        {
            //mainPictureBoxSize.Width = size.Width;
            //mainPictureBoxSize.Height = size.Height;
            mainPictureBox = new PictureBox();
            mainPictureBoxParent = parent;
            mainPictureBox.Size = size;
            mainPictureBox.Location = pictureBox.Location = new Point(parent.Width / 2 - mainPictureBoxSize.Width / 2, parent.Height / 2 - mainPictureBoxSize.Height / 2);
            mainPictureBox.BackColor = Color.White;
        }
    }
}
