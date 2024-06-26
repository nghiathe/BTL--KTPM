using DAL;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLquannet.FoodModel
{

    public partial class frmEditFood : Form
    {
        public int CatID;
        public int FoodID;
        public bool imageUpdated = false;

        public frmEditFood()
        {
            InitializeComponent();
        }
        private void EditFood_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadCboCat();
        }
        private void LoadCboCat()
        {
            cboCategory.DataSource = CategoryDAL.Instance.GetCategories();
            cboCategory.ValueMember = "categoryID";
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.SelectedIndex = -1;
        }
        private void LoadDataGridView()
        {
            dgvFood.DataSource = EditFoodDAL.Instance.GetAllFood();
            dgvFood.Columns["FoodName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFood.Columns["Foodid"].HeaderText = "Mã hàng";
            dgvFood.Columns["FoodName"].HeaderText = "Tên hàng";
            dgvFood.Columns["Price"].HeaderText = "Đơn giá bán";
            dgvFood.Columns["Intakeprice"].HeaderText = "Đơn giá nhập";
            dgvFood.Columns["inventory"].HeaderText = "Tồn kho";
            dgvFood.Columns["Categoryid"].HeaderText = "Mã loại hàng";
            dgvFood.Columns["image"].Visible = false;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFood.Rows[e.RowIndex];
                FoodID = Convert.ToInt32(row.Cells["FoodID"].Value.ToString());
                txtFoodName.Text = row.Cells["FoodName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtIntakePrice.Text = row.Cells["IntakePrice"].Value.ToString();
                txtInventory.Text = row.Cells["Inventory"].Value.ToString();
                CatID = Convert.ToInt32(row.Cells["CategoryID"].Value.ToString());
                cboCategory.SelectedValue = CatID;
                // Lấy ảnh từ cơ sở dữ liệu
                picFood.Image = ImageProcess.ByteArrayToImage((byte[])row.Cells["image"].Value);
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFood.SelectedRows[0];
                int rowId = Convert.ToInt32(selectedRow.Cells["FoodID"].Value);

                EditFoodDAL.Instance.DeleteFood(rowId);
                dgvFood.Rows.Remove(selectedRow);
                MessageBox.Show("Dòng đã được xóa từ cơ sở dữ liệu và DataGridView.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {

                Food food = new Food
                {
                    FoodID = Convert.ToInt32(FoodID),
                    FoodName = txtFoodName.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    IntakePrice = Convert.ToDecimal(txtIntakePrice.Text),
                    Inventory = Convert.ToInt32(txtInventory.Text),
                    CategoryID = Convert.ToInt32(cboCategory.SelectedValue),
                    Image = picFood.Image
                };

                EditFoodDAL.Instance.UpdateFood(food, imageUpdated);
                LoadDataGridView();
                MessageBox.Show("Cập nhật món ăn thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    if (imagePath != null)
                    {
                        picFood.Image = Image.FromFile(imagePath);
                        imageUpdated = true;
                    }
                }
            }

        }
        
    }

}
