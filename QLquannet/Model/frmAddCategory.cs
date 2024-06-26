using DAL;
using System;
using System.Windows.Forms;

namespace QLquannet.Model
{
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void btnCnfirmAddCat_Click(object sender, EventArgs e)
        {
            if (txtCat.Text == "")
            {
                MessageBox.Show("Chưa nhập tên loại món!");
            }
            else
            {
                string categoryName = txtCat.Text;

                AddCategoryDAL addCategoryDAL = new AddCategoryDAL();

                bool isAdded = addCategoryDAL.AddCategory(categoryName);
                if (isAdded)
                {
                    MessageBox.Show("Thêm loại đồ ăn thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại đồ ăn!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
