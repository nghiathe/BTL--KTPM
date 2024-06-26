using DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLquannet.Model
{
    public partial class frmIntakeFood : Form
    {
        private DataTable originalData;

        public frmIntakeFood()
        {
            InitializeComponent();
        }
       
        private void frmIntakeFood_Load(object sender, EventArgs e)
        {
            frmIntakeFoodDataINIT();
        }
        private void frmIntakeFoodDataINIT()
        {
            originalData = EditFoodDAL.Instance.GetAllFood();
            AddTempColumns(originalData);
            LoadDataGridView(originalData);
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtMaHoaDon.Enabled = false;
            txtSoLuong.Enabled = false;
            LoadCboCat();
            txtMaHoaDon.Text = BillingDAL.Instance.GetMaxBillingID().ToString();
        }
        private void LoadCboCat()
        {
            cboCat.DataSource = CategoryDAL.Instance.GetCategories();
            cboCat.DisplayMember = "CategoryName";
            cboCat.ValueMember = "CategoryID";
            cboCat.SelectedIndex = -1;
        }
        private void LoadCboFood(int categoryId)
        {
            cboFood.DataSource = FoodDAL.Instance.GetFoods(categoryId);
            cboFood.DisplayMember = "FoodName";
            cboFood.ValueMember = "FoodID";
            cboFood.SelectedIndex = -1;
        }
        private void LoadDataGridView(DataTable dataSource)
        {
            dgvFood.DataSource = dataSource;
            dgvFood.Columns[0].Visible = false;
            dgvFood.Columns[2].Visible = false;
            dgvFood.Columns[5].Visible = false;
            dgvFood.Columns[6].Visible = false;
            dgvFood.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFood.Columns[1].HeaderText = "Tên hàng";
            dgvFood.Columns[3].HeaderText = "Giá nhập";
            dgvFood.Columns[4].HeaderText = "Tồn kho";
            dgvFood.Columns["SoLuongThem"].HeaderText = "Số lượng thêm";
            dgvFood.Columns["TamTinh"].HeaderText = "Tạm tính";

            dgvFood.CellClick += dataGridView_CellClick;
        }

        private void Filter(int? categoryId, byte? foodId = null, string search = "")
        {
            foreach (DataGridViewRow row in dgvFood.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool categoryMatch = categoryId == null || (int)row.Cells["CategoryID"].Value == categoryId;
                    bool foodMatch = foodId == null || (byte)row.Cells["FoodID"].Value == foodId;
                    bool searchTextMatch = search == "" || row.Cells["FoodName"].Value.ToString().ToLower().Contains(search.ToLower());

                    row.Visible = categoryMatch && foodMatch && searchTextMatch;
                }
            }
        }

        private void HandlelblTongTien()
        {
            decimal amount = 0;
            foreach (DataGridViewRow row in dgvFood.Rows)
            {
                amount += Convert.ToDecimal(row.Cells["intakeprice"].Value) * Convert.ToInt32(row.Cells["SoLuongThem"].Value);
            }
            lbTongTien.Text = amount.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvFood.Columns[e.ColumnIndex].DataPropertyName == "SoLuongThem")
                {
                    int currentValue = dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null
                                        ? 0
                                        : (int)dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = currentValue + 5;

                    int currentTamTinh = dgvFood.Rows[e.RowIndex].Cells["inventory"].Value == null
                                         ? 0
                                         : (int)dgvFood.Rows[e.RowIndex].Cells["inventory"].Value;

                    dgvFood.Rows[e.RowIndex].Cells["TamTinh"].Value = currentTamTinh + (int)dgvFood.Rows[e.RowIndex].Cells["SoLuongThem"].Value;
                }

                txtMaHang.Text = dgvFood.Rows[e.RowIndex].Cells["FoodID"].Value.ToString();
                txtTenHang.Text = dgvFood.Rows[e.RowIndex].Cells["FoodName"].Value.ToString();
                txtSoLuong.Text = dgvFood.Rows[e.RowIndex].Cells["SoLuongThem"].Value.ToString();
                txtSoLuong.Enabled = true;
            }
        }
        private void dgvFood_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            HandlelblTongTien();
        }
        private void AddTempColumns(DataTable table)
        {
            if (!table.Columns.Contains("SoLuongThem"))
            {
                table.Columns.Add("SoLuongThem", typeof(int));

                foreach (DataRow row in table.Rows)
                {
                    row["SoLuongThem"] = 0;
                }
            }

            // Thêm cột "TamTinh" nếu chưa tồn tại
            if (!table.Columns.Contains("TamTinh"))
            {
                table.Columns.Add("TamTinh", typeof(int));

                foreach (DataRow row in table.Rows)
                {
                    row["TamTinh"] = 0;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtMaHang.Clear();
            txtSoLuong.Enabled = false;
            foreach (DataGridViewRow row in dgvFood.Rows)
            {
                if (row.Cells["SoLuongThem"] != null)
                {
                    row.Cells["SoLuongThem"].Value = 0;
                }
                if (row.Cells["TamTinh"] != null)
                {
                    row.Cells["TamTinh"].Value = 0;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 37 || e.KeyChar == 39 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHang != null && txtMaHang.Text != "")
            {
                int rowIndex = Convert.ToInt32(txtMaHang.Text) - 1;
                int value;
             
                if (!int.TryParse(txtSoLuong.Text, out value))
                {
                    value = 0;
                }
                dgvFood.Rows[rowIndex].Cells["SoLuongThem"].Value = value;
                dgvFood.Rows[rowIndex].Cells["TamTinh"].Value = value + (int)dgvFood.Rows[rowIndex].Cells["inventory"].Value;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đồ!");
            }
        }


        private void dgvFood_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException || e.Exception is InvalidCastException)
            {
                dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0; 
                e.Cancel = true;
            }
        }

        private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCat.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cboCat.SelectedItem;
                int categoryId = (int)selectedRow["categoryid"];
                LoadCboFood(categoryId);
                Filter(categoryId: categoryId);
            }
        }
        private void cboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFood.SelectedIndex != -1)
            {
                DataRowView selectedRowCat = (DataRowView)cboCat.SelectedItem;
                int categoryId = (int)selectedRowCat["categoryid"];
                DataRowView selectedRowFood = (DataRowView)cboFood.SelectedItem;
                byte foodId = (byte)selectedRowFood["foodid"];
                Filter(categoryId: categoryId, foodId: foodId);

            }
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            int? categoryId = (int?)cboCat.SelectedValue;
            byte? foodId = (byte?)cboFood.SelectedValue;
            Filter(categoryId: categoryId, foodId: foodId, search: txtSearchFood.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboCat.SelectedIndex = -1;
            cboFood.SelectedIndex = -1;
            txtSearchFood.Text = "";
            lbTongTien.Text = "";
            foreach(DataGridViewRow row in dgvFood.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvFood.Rows)
            {
                if (Convert.ToInt32(row.Cells["SoLuongThem"].Value) != 0)
                {
                    BillingDAL.Instance.CheckOutFoodIntake((byte)row.Cells["FoodID"].Value, Convert.ToInt32(row.Cells["SoLuongThem"].Value));
                }
            }
            MessageBox.Show("Đã nhập đồ ăn thành công!");
            frmIntakeFoodDataINIT();
        }

    }
}
