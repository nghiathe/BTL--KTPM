using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLquannet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool drag = false;
        Point start_point = new Point();

        private void pnlMovable_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pnlMovable_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void pnlMovable_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }


        private void btnComputer_Click(object sender, EventArgs e)
        {

            LoadForm(new frmComputer());
            ChangeColorMainBtn(btnComputer, null);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            LoadForm(new frmFood());
            ChangeColorMainBtn(btnFood, null);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            LoadForm(new frmBilling());
            ChangeColorMainBtn(btnBill, null);
        }
        private void btnMaintain_Click(object sender, EventArgs e)
        {
            LoadForm(new frmMaintainance());
            ChangeColorMainBtn(btnMaintain, null);
        }
        private void btnIntake_Click(object sender, EventArgs e)
        {
            LoadForm(new frmIntakeFood());
            ChangeColorMainBtn(btnIntake, null);
        }
        private void LoadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();
        }

        void ChangeColorMainBtn(object sender, EventArgs e)
        {
            foreach (Control c in pnlMenubar.Controls)
            {
                c.BackColor = Color.FromArgb(24, 30, 54);
            }
            Control cl = (Control)sender;
            cl.BackColor = Color.Gray;

        }

        private void bthLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

    }
}
