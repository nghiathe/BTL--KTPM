using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLquannet
{
    public partial class frmMaintainance : Form
    {
        byte cid;
        int bid;
        string[] baotri = { "CPU", "VGA", "RAM", "HDD", "SSD", "Bàn phím", "Chuột", "Màn hình", "Phần mềm", "Khác", "Tai nghe", "Ghế" };
        public frmMaintainance()
        {
            InitializeComponent();
            LoadCom();
            txtNhanvien.Text = Employee.fullName;
            cbBaotri.DataSource = baotri;
            txtTotal.KeyPress += new KeyPressEventHandler(txtTotal_KeyPress);
        }

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Computer com = btn.Tag as Computer;
            cid = com.ComId;
            if (com.ComStatus == 0)
            {
                txtTT.Text = "Offline";
            }
            else if (com.ComStatus == 1)
            {
                txtTT.Text = "Online";
            }
            else
            {
                txtTT.Text = "Error";
            }
            gbMay.Text = com.ComName;
            LoadMaintainanceDetail(cid);
            ChangeColorComBtn(btn, null);
            ResetValue();
        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (txtTT.Text == "Online" || txtTT.Text == "Offline")
            {
                MessageBox.Show("Máy này không bảo trì!");
            }
            else if (gbMay.Text == "")
            {
                MessageBox.Show("Chưa chọn máy!");
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Chưa báo giá bảo trì!");
            }
            else
            {
                BillingDAL.Instance.CheckOutMaintainance(bid, Employee.emId, Convert.ToDecimal(txtTotal.Text), cid);
                LoadCom();
                LoadMaintainanceDetail(cid);
                ResetValue();
            }
        }

        private void btnBaoloi_Click(object sender, EventArgs e)
        {
            if (txtTT.Text == "Online")
            {
                MessageBox.Show("Máy đang online!");
            }
            else if (gbMay.Text == "")
            {
                MessageBox.Show("Chưa chọn máy!");
            }
            else if (cbBaotri.Text == "")
            {
                MessageBox.Show("Chưa chọn bộ phận cần bảo trì!");
            }
            else
            {
                if (MaintainanceDAL.Instance.GetUnCheckOutMaintainance(cid) == -1)
                {
                    MaintainanceDAL.Instance.StartMaintainance(cid);
                    MaintainanceDAL.Instance.AddMaintainanceDetail(MaintainanceDAL.Instance.GetMaintainanceIDMAX(), cbBaotri.Text, txtDetail.Text);
                }
                else
                {
                    MaintainanceDAL.Instance.AddMaintainanceDetail(MaintainanceDAL.Instance.GetUnCheckOutMaintainance(cid), cbBaotri.Text, txtDetail.Text);

                }
                LoadCom();
                LoadMaintainanceDetail(cid);
                ResetValue();
            }
        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Methods
        void LoadCom()
        {
            flpCom.Controls.Clear();
            List<Computer> listCom = ComputerDAL.Instance.LoadFullCom();
            int online = 0;
            int offline = 0;
            int error = 0;
            foreach (Computer com in listCom)
            {
                Button btn = new Button()
                {
                    Width = ComputerDAL.ComWidth,
                    Height = ComputerDAL.ComHeight,
                };

                btn.Click += btn_Click;

                btn.FlatStyle = FlatStyle.Flat;

                btn.Tag = com;

                switch (com.ComStatus)
                {
                    case 0:
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 100);
                        btn.BackColor = Color.LightGray;
                        btn.Text = com.ComName + Environment.NewLine + "Offline";
                        offline++;
                        break;

                    case 1:
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 228, 178);
                        btn.BackColor = Color.Aqua;
                        btn.Text = com.ComName + Environment.NewLine + "Online";
                        online++;
                        break;
                    default:
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 135, 50);
                        btn.BackColor = Color.OrangeRed;
                        btn.Text = com.ComName + Environment.NewLine + "Error";
                        error++;
                        break;
                }
                flpCom.Controls.Add(btn);
                txtAvailable.Text = offline.ToString();
                txtUsing.Text = online.ToString();
                txtError.Text = error.ToString();
                ResetValue();
            }
        }

        void ChangeColorComBtn(object sender, EventArgs e)
        {
            foreach (Control c in flpCom.Controls)
            {
                if (c.Text.Contains("Online"))
                {
                    c.BackColor = Color.Aqua;
                }
                if (c.Text.Contains("Offline"))
                {
                    c.BackColor = Color.LightGray;
                }
                if (c.Text.Contains("Error"))
                {
                    c.BackColor = Color.OrangeRed;
                }

            }
            Control cl = (Control)sender;
            if (cl.Text.Contains("Online"))
            {
                cl.BackColor = Color.FromArgb(100, 228, 178);
            }
            if (cl.Text.Contains("Offline"))
            {
                cl.BackColor = Color.FromArgb(200, 200, 100);
            }
            if (cl.Text.Contains("Error"))
            {
                cl.BackColor = Color.FromArgb(228, 135, 50);
            }
        }

        void LoadMaintainanceDetail(byte comid)
        {
            lvMaintain.Items.Clear();
            List<Maintainance> ml = MaintainanceDAL.Instance.GetListMaintainance(comid);
            foreach (Maintainance m in ml)
            {
                ListViewItem lvi = new ListViewItem(m.Component.ToString());
                if (m.Description != null)
                {
                    lvi.SubItems.Add(m.Description.ToString());
                }
                lvMaintain.Items.Add(lvi);
                bid = m.BillingId;
            }
        }

        void ResetValue()
        {
            cbBaotri.Text = "";
            txtDetail.Text = "";
            txtTotal.Text = "";
        }
        #endregion

    }
}
