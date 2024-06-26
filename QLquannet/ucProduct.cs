using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public event EventHandler onSelect = null;
        public int id {  get; set; }
        public string PPrice {
            get { return lbPrice.Text; }
            set { lbPrice.Text = value; }
        }
        public string PCategory {  get; set; }
        public string PName
        {
            get { return lbPname.Text; }
            set { lbPname.Text = value; }
        }
        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void DrawCustomBorder()
        {
            // Tạo màu sáng hơn hoặc tối hơn cho viền
            Color borderColor = ControlPaint.Dark(panel1.BackColor);

            // Vẽ viền cho Panel
            panel1.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
            };
        }
    }
}
