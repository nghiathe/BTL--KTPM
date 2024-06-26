using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace QLquannet
{
    public partial class frmBilling : Form
    {
        decimal inc = 0;
        decimal outc = 0;
        decimal profit = 0;
        CultureInfo ct = new CultureInfo("vi-VN");
        private DateTimePicker lastSelectedDateTimePicker;
        public frmBilling()
        {
            InitializeComponent();
            LoadDate();
            ShowBill(tpBd.MinDate, tpKt.MaxDate);

            txtNhanvien.TextChanged += new EventHandler(txtNhanvien_TextChanged);
            rbThu.CheckedChanged += new EventHandler(rbThuChi_CheckedChanged);
            rbChi.CheckedChanged += new EventHandler(rbThuChi_CheckedChanged);

        }

        #region Events
        private void rbKhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKhoang.Checked)
            {
                gbKhoang.Enabled = true;
                ShowBill(tpBd.Value, tpKt.Value);
                ResetValue();
            }
            else
            {
                gbKhoang.Enabled = false;
            }
        }

        private void tpKt_ValueChanged(object sender, EventArgs e)
        {
            ShowBill(tpBd.Value, tpKt.Value);
            txtIn.Text = inc.ToString("c", ct);
            txtOut.Text = outc.ToString("c", ct);
            txtProfit.Text = profit.ToString("c", ct);
            ResetValue();
        }

        private void tpBd_ValueChanged(object sender, EventArgs e)
        {
            ShowBill(tpBd.Value, tpKt.Value);
            txtIn.Text = inc.ToString("c", ct);
            txtOut.Text = outc.ToString("c", ct);
            txtProfit.Text = profit.ToString("c", ct);
            ResetValue();
        }

        private void rbHai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHai.Checked)
            {
                gbHai.Enabled = true;
                ResetValue();
            }
            else
            {
                gbHai.Enabled = false;
            }
        }

        private void tpTs_ValueChanged(object sender, EventArgs e)
        {
            lastSelectedDateTimePicker = tpTs;
            ApplyDateFilter();
            ResetValue();
        }

        private void tpTe_ValueChanged(object sender, EventArgs e)
        {
            lastSelectedDateTimePicker = tpTe;
            ApplyDateFilter();
            ResetValue();
        }

        private void rbThuChi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKhoang.Checked)
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                ShowBill(tpBd.Value, tpKt.Value, txtNhanvien.Text, billingType);
                txtIn.Text = inc.ToString("c", ct);
                txtOut.Text = outc.ToString("c", ct);
                txtProfit.Text = profit.ToString("c", ct);
            }
            else if (rbHai.Checked)
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                DateTime fday = new DateTime(lastSelectedDateTimePicker.Value.Year, lastSelectedDateTimePicker.Value.Month, 1);
                DateTime lday = fday.AddMonths(1);
                ShowBill(fday, lday, txtNhanvien.Text, billingType);

                if (lastSelectedDateTimePicker == tpTs)
                {
                    txtProfitMonth.Text = (profit).ToString("c", ct);
                }
                else if (lastSelectedDateTimePicker == tpTe)
                {
                    txtProfitOtherMonth.Text = (profit).ToString("c", ct);
                }
            }
            else
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                ShowBill(tpBd.MinDate, tpKt.MaxDate, txtNhanvien.Text, billingType);
            }
        }

        private void txtNhanvien_TextChanged(object sender, EventArgs e)
        {
            if (rbKhoang.Checked)
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                ShowBill(tpBd.Value, tpKt.Value, txtNhanvien.Text, billingType);
                txtIn.Text = inc.ToString("c", ct);
                txtOut.Text = outc.ToString("c", ct);
                txtProfit.Text = profit.ToString("c", ct);
            }
            else if (rbHai.Checked)
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                DateTime fday = new DateTime(lastSelectedDateTimePicker.Value.Year, lastSelectedDateTimePicker.Value.Month, 1);
                DateTime lday = fday.AddMonths(1);
                ShowBill(fday, lday, txtNhanvien.Text, billingType);

                if (lastSelectedDateTimePicker == tpTs)
                {
                    txtProfitMonth.Text = (profit).ToString("c", ct);
                }
                else if (lastSelectedDateTimePicker == tpTe)
                {
                    txtProfitOtherMonth.Text = (profit).ToString("c", ct);
                }
            }
            else
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                ShowBill(tpBd.MinDate, tpKt.MaxDate, txtNhanvien.Text, billingType);
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        #endregion

        #region Methods

        void LoadDate()
        {
            DateTime today = DateTime.Now;
            tpBd.Value = new DateTime(today.Year, today.Month, 1);
            tpKt.Value = tpBd.Value.AddMonths(1);
            tpTs.Value = new DateTime(today.Year, today.Month, 1);
            tpTe.Value = tpTs.Value.AddMonths(-1);
        }

        void ShowBill(DateTime ngaybd, DateTime ngaykt, string search = "", int? billingType = null)
        {
            lvBill.Items.Clear();
            List<Billing> lb = BillingDAL.Instance.loadBillList(ngaybd, ngaykt);
            decimal income = 0;
            decimal outcome = 0;
            foreach (Billing b in lb)
            {
                if ((string.IsNullOrEmpty(search) || b.EmName.ToString().ToLower().Contains(search)) && (!billingType.HasValue || b.BType == billingType.Value))
                {
                    ListViewItem lvi = new ListViewItem(b.BDate.ToString());
                    lvi.SubItems.Add(b.EmName.ToString());
                    if (b.BType == 1)
                    {
                        lvi.SubItems.Add("Thu");
                    }
                    else
                    {
                        lvi.SubItems.Add("Chi");
                    }

                    lvi.SubItems.Add(b.SCost.ToString());
                    lvi.SubItems.Add(b.MCost.ToString());
                    lvi.SubItems.Add(b.FCost.ToString());
                    lvi.SubItems.Add(b.Amount.ToString());
                    if (b.BType == 1)
                    {
                        income += b.Amount;
                    }
                    else
                    {
                        outcome += b.Amount;
                    }

                    lvBill.Items.Add(lvi);
                }
            }
            inc = income;
            outc = outcome;
            profit = income - outcome;
        }

        void ApplyDateFilter()
        {
            if (lastSelectedDateTimePicker != null)
            {
                DateTime fday = new DateTime(lastSelectedDateTimePicker.Value.Year, lastSelectedDateTimePicker.Value.Month, 1);
                DateTime lday = fday.AddMonths(1);
                ShowBill(fday, lday);

                if (lastSelectedDateTimePicker == tpTs)
                {
                    txtProfitMonth.Text = (profit).ToString("c", ct);
                }
                else if (lastSelectedDateTimePicker == tpTe)
                {
                    txtProfitOtherMonth.Text = (profit).ToString("c", ct);
                }
            }
        }

        void ResetValue()
        {
            txtNhanvien.Text = "";
            rbChi.Checked = false;
            rbThu.Checked = false;
        }
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Model.frmPrintRecipe fp = new Model.frmPrintRecipe();
            fp.Show();
        }

    }
}
