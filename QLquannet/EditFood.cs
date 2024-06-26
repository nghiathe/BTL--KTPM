using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLquannet.FoodModel
{
    
    public partial class EditFood : Form
    {
        public int CatID;
        public string CatName;
        public string FoodID;
        public string imagePath;
        public EditFood()
        {
            InitializeComponent();
        }
        private void EditFood_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=Qlquannet;Integrated Security=True";
            string query = "Select * FROM Food";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[6].Width = 200;
                    }
                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIntakePrice_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that the row index is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtFoodName.Text = row.Cells["FoodName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtIntakePrice.Text = row.Cells["IntakePrice"].Value.ToString();
                txtInventory.Text = row.Cells["Inventory"].Value.ToString();
                CatID = Convert.ToInt32(row.Cells["CategoryID"].Value.ToString());
                CheckCboID();
                // Lấy ảnh từ cơ sở dữ liệu
                byte[] imageBytes = (byte[])row.Cells["Image"].Value;
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        picFood.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picFood.Image = null;
                }
            }
        }

        private void CheckCboID()
        {
            string Strconn = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=Qlquannet;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Strconn);
            string qry = "Select * from  Category where CategoryID = @CatID";
            using (SqlCommand cmd = new SqlCommand(qry, conn))
            {
                cmd.Parameters.AddWithValue("@CatID", CatID);
                conn.Open();
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CatName = reader["CategoryName"].ToString();
                    }
                }

            }
            cboCategory.Text = CatName;
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int rowId = Convert.ToInt32(selectedRow.Cells["FoodID"].Value); // Thay "ID" bằng tên cột chứa ID

                // Xóa dữ liệu từ cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=Qlquannet;Integrated Security=True";
                string query = "DELETE FROM Food WHERE FoodID = @ID"; // Thay "YourTable" bằng tên bảng của bạn

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", rowId);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Nếu xóa thành công từ cơ sở dữ liệu, cũng xóa dòng từ DataGridView
                            dataGridView1.Rows.Remove(selectedRow);
                            MessageBox.Show("Dòng đã được xóa từ cơ sở dữ liệu và DataGridView.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa dòng từ cơ sở dữ liệu.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string connectionString = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=Qlquannet;Integrated Security=True";
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn cập nhật
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Food SET FoodName = '"+txtFoodName.Text+"', Price = '"+Convert.ToDecimal(txtPrice.ToString())+ "', IntakePrice = '"+Convert.ToDecimal(txtIntakePrice.ToString())+"', Inventory = '"+Convert.ToInt32(txtInventory.ToString())+"', Image = @Image WHERE '" + FoodID+"' = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                // Cập nhật lại DataGridView nếu cần
                // dataGridView1.Rows[selectedRow.Index].Cells["ColumnName"].Value = newData;
                // Thay "ColumnName" bằng tên cột bạn muốn cập nhật
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
                    // Get the path of specified file
                    imagePath = openFileDialog.FileName;

                    // Display the image in PictureBox
                }
            }
            picFood.Image = Image.FromFile(imagePath);
        }
    }

}
