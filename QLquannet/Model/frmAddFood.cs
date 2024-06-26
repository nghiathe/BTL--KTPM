using DAL;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLquannet.FoodModel
{
    public partial class frmAddFood : Form
    {
        public string imagePath;
        public frmAddFood()
        {
            InitializeComponent();
        }
        private void AddFood_Load(object sender, EventArgs e)
        {
            LoadCboCat();
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
                    imagePath = openFileDialog.FileName;
                }
            }
        }

        private void btnConfirmAddFood_Click(object sender, EventArgs e)
        {
            //CheckCboID();

            Food food = new Food
            {
                FoodName = txtFoodName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                IntakePrice = Convert.ToDecimal(txtIntakePrice.Text),
                Inventory = Convert.ToInt32(txtInventory.Text),
                CategoryID = Convert.ToInt32(cboCategory.SelectedValue),
                Image = Image.FromFile(imagePath)
            };

            AddFoodDAL.Instance.SaveFood(food);
            MessageBox.Show("Thêm món ăn thành công!");
            this.Close();

        }

        private void LoadCboCat()
        {
            cboCategory.DataSource = CategoryDAL.Instance.GetCategories();
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
