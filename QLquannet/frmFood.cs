using DAL;
using DTO;
using QLquannet.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace QLquannet
{
    public partial class frmFood : Form
    {

        public frmFood()
        {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            LoadCategories();
            ProductPanel.Controls.Clear();
            LoadMenu();
            LoadcboZone();
            dgvFoodList.Rows.Clear();
        }

        private void LoadcboZone()
        {
            cboZone.DataSource = ZoneDAL.Instance.getZones();
            cboZone.DisplayMember = "ZoneName";
            cboZone.ValueMember = "ZoneID";
            cboZone.SelectedIndex = -1;
        }
        private void LoadcboCom(byte zoneid)
        {
            cboCom.DataSource = ComputerDAL.Instance.GetComs(zoneid);
            cboCom.DisplayMember = "ComputerName";
            cboCom.ValueMember = "ComputerID";
            cboCom.SelectedIndex = -1;
        }
        private void LoadCategories()
        {
            DataTable dt = FoodDAL.Instance.GetCategories();
            foreach (DataRow row in dt.Rows)
            {
                Button b = new Button
                {
                    BackColor = Color.White,
                    Size = new Size(80, 50),
                    Text = row["CategoryName"].ToString()
                };

                b.Click += new EventHandler(btn_Click);
                CategoryPanel.Controls.Add(b);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LoadMenu(btn.Text);
        }

        private void LoadMenu(string categoryName = null)
        {
            ProductPanel.Controls.Clear();
            ProductPanel.SuspendLayout();

            List<Food> foodls = FoodDAL.Instance.LoadMenu(categoryName);
            foreach (Food food in foodls)
            {
                ucProduct ucproduct = new ucProduct
                {
                    id = food.FoodID,
                    PName = food.FoodName,
                    PPrice = food.Price.ToString(),
                    PImage = food.Image
                };

                ucproduct.PictureBoxClick += UcProduct_Clicked;

                ProductPanel.Controls.Add(ucproduct);
            }
            ProductPanel.ResumeLayout();
        }

        private void UcProduct_Clicked(object sender, EventArgs e)
        {
            int i = 0;
            ucProduct clickedProduct = sender as ucProduct;
            bool productFound = false;
            foreach (DataGridViewRow row in dgvFoodList.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == clickedProduct.id)
                {
                    int quantity = int.Parse(row.Cells["Qty"].Value.ToString()) + 1;
                    row.Cells["Qty"].Value = quantity;
                    row.Cells["Amount"].Value = quantity * decimal.Parse(row.Cells["Price"].Value.ToString());
                    productFound = true;
                    
                    break;
                }
            }
            if (!productFound)
            {
                int index = dgvFoodList.Rows.Count; // Tăng số thứ tự dựa trên số lượng hàng hiện có
                dgvFoodList.Rows.Add(new object[] { index, clickedProduct.id, clickedProduct.PName, 1, clickedProduct.PPrice, clickedProduct.PPrice });
            }

        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearchFood.Text.Trim().ToLower());
            }
        }

        private void txtSearchFood_Click(object sender, EventArgs e)
        {
            txtSearchFood.SelectAll();
        }

        private void LoadFoodDetail(byte comid)
        {
            List<Food> foods = FoodDAL.Instance.GetFoodDetail(comid);

            dgvFoodList.Rows.Clear();

            int i = 1;
            foreach (Food food in foods)
            {
                int rowIndex = dgvFoodList.Rows.Add();
                DataGridViewRow newRow = dgvFoodList.Rows[rowIndex];
                newRow.Cells[0].Value = i; i++;
                newRow.Cells[1].Value = food.FoodID;
                newRow.Cells[2].Value = food.FoodName;
                newRow.Cells[3].Value = food.Count;
                newRow.Cells[4].Value = food.Price;
                newRow.Cells[5].Value = food.Cost;
            }
        }

        private void HandlelblTongTien()
        {
            decimal amount = 0;
            foreach(DataGridViewRow row in dgvFoodList.Rows)
            {
                amount += Convert.ToDecimal(row.Cells[5].Value);
            }
            lbTongtien.Text = amount.ToString();
        }
        private void dgvFoodList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            HandlelblTongTien();
        }
        private void dgvFoodList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                HandlelblTongTien();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FoodModel.frmAddFood AF = new FoodModel.frmAddFood();
            AF.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FoodModel.frmEditFood EF = new FoodModel.frmEditFood();
            EF.Show();
        }
        private void btnIntake_Click(object sender, EventArgs e)
        {
            frmIntakeFood IF = new frmIntakeFood();
            IF.Show();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Model.frmAddCategory AC = new Model.frmAddCategory();
            AC.Show();
        }

        private void cboZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFoodList.Rows.Clear();
            if (cboZone.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cboZone.SelectedItem;
                LoadcboCom((byte)selectedRow["ZoneID"]);
            }
        }


        private void cboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFoodList.Rows.Clear();
            if (cboCom.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cboCom.SelectedItem;
                LoadFoodDetail((byte)selectedRow["ComputerID"]);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvFoodList.Rows.Clear();
            LoadMenu();
            lbTongtien.Text = "0.00";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboCom.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn máy!");
                return;
            }
            byte computerID;
            DataRowView selectedRow = (DataRowView)cboCom.SelectedItem;
            try
            {
                computerID = (byte)selectedRow["ComputerID"];
            }
            catch{ return; }

            int billingID;
            try
            {
                billingID = FoodDAL.Instance.GetUncheckBillingID(computerID);
                if (billingID == -1)
                {
                    MessageBox.Show("Máy chưa được bật!");
                    return; 
                }
            }
            catch { return; }
            foreach (DataGridViewRow row in dgvFoodList.Rows)
            {
                int foodID = Convert.ToInt32(row.Cells[1].Value);
                int count = Convert.ToInt32(row.Cells[3].Value);
                if (FoodDAL.Instance.FoodDetailsExist(billingID, foodID))
                {
                    FoodDAL.Instance.UpdateFoodDetails(billingID, foodID, count);
                }
                else
                {
                FoodDAL.Instance.SaveFoodDetails(billingID, foodID, count);
                }
            }
            MessageBox.Show("Dữ liệu đã được lưu thành công!");

        }

    }
}

