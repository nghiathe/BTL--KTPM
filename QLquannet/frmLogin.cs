using DAL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLquannet
{
    public partial class frmLogin : Form
    {
        Login lg = new Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            txtusername.SelectAll();
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.SelectAll();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            lg.username = txtusername.Text;
            lg.password = txtpassword.Text;
            string rs = (string)LoginDAL.Instance.Login(lg);
            if (rs != null)
            {
                Employee.emId = (byte)LoginDAL.Instance.GetEmployeeId(lg);
                Employee.fullName = rs;
                btnlogin.ForeColor = Color.Blue;
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
