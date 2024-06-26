using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLquannet
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
            DrawCustomBorder();
        }

        public event EventHandler PictureBoxClick;
        public int id { get; set; }
        public string PPrice
        {
            get { return lbPrice.Text; }
            set { lbPrice.Text = value; }
        }
        public string PCategory { get; set; }
        public string PName
        {
            get { return lbPname.Text; }
            set { lbPname.Text = value; }
        }
        public Image PImage
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBoxClick?.Invoke(this, e);
        }
        private void DrawCustomBorder()
        {
            Color borderColor = ControlPaint.Dark(panel1.BackColor);
            panel1.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
            };
        }


    }
}
