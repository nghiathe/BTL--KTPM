using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace DTO
{
    public class Food
    {
        private int foodID;
        private decimal intakePrice;
        private int inventory;
        private int categoryID;
        private string foodName;
        private decimal price;
        private Image image;
        private int count;
        private decimal cost;

        public Food() { }
        public Food(DataRow row)
        {
            this.FoodID = (byte)row["foodid"];
            this.FoodName = row["foodname"].ToString();
            this.categoryID = (int)row["categoryid"];
            this.Count = row["count"] is DBNull ? 0 : Convert.ToInt32(row["count"]);
            this.Price = (decimal)row["price"];
            this.Cost =row["cost"] is DBNull ? 0 : Convert.ToDecimal(row["cost"]);
            this.Image = Image.FromStream(new MemoryStream((byte[])row["image"]));
        }
        public int FoodID { get => foodID; set => foodID = value; }
        public decimal IntakePrice { get => intakePrice; set => intakePrice = value; }
        public int Inventory { get => inventory; set => inventory = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public decimal Price { get => price; set => price = value; }
        public Image Image { get => image; set => image = value; }
        public int Count { get => count; set => count = value; }
        public decimal Cost { get => cost; set => cost = value; }
    }

    public class Category
    {
        private int categoryID;
        private string categoryName;
        public Category(DataRow row)
        {
            this.CategoryID = (int)row["categoryid"];
            this.CategoryName = row["categoryname"].ToString();
        }

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
