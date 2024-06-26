using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquannet.FoodModel
{
    public partial class AddFood : Form
    {
        public string imagePath;
        public string CatID;
        public AddFood()
        {
            InitializeComponent();
        }
        private void AddFood_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=Qlquannet;Integrated Security=True";
            string query = "SELECT CategoryName FROM Category";
            LoadComboBox(cboCategory, connectionString, query);
  
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        public static byte[] ImageToByteArray(string imagePath)
        {
            using (Image image = Image.FromFile(imagePath))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }

        public static void SaveImageToDatabase(string productName, decimal productPrice, decimal productIntakePrice, int Inventory, int CategoryID, byte[] imageBytes)
        {
            string connectionString = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=Qlquannet;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Food (FoodName, Price, IntakePrice, Inventory, CategoryID, Image) VALUES (@Name, @Price, @IntakePrice, @Inventory, @CategoryID, @Image)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@Name", productName);
                    cmd.Parameters.AddWithValue("@Price", productPrice);
                    cmd.Parameters.AddWithValue("@IntakePrice", productIntakePrice);
                    cmd.Parameters.AddWithValue("@Inventory", Inventory);
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    cmd.Parameters.AddWithValue("@Image", imageBytes);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnConfirmAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes = ImageToByteArray(imagePath);
                CheckCboID();
                SaveImageToDatabase(txtFoodName.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToDecimal(txtIntakePrice.Text), Convert.ToInt32(txtInventory.Text), Convert.ToInt32(CatID), imageBytes);
                MessageBox.Show("Thêm món ăn thành công!");
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
            

        }

        private void LoadComboBox(ComboBox comboBox, string connectionString, string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckCboID()
        {
            string Strconn = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=Qlquannet;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Strconn);
            string qry = "Select * from  Category where CategoryName = @CatName";
            using (SqlCommand cmd = new SqlCommand(qry, conn))
            {
                cmd.Parameters.AddWithValue("@CatName", cboCategory.SelectedItem.ToString());
                conn.Open();
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CatID = reader["CategoryID"].ToString();
                    }
                }
            }
        }
    }
}
