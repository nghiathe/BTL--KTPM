using DTO;
using System;
using System.Data;

namespace DAL
{
    public class AddFoodDAL
    {
        private static AddFoodDAL instance;

        public static AddFoodDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AddFoodDAL();
                }
                return AddFoodDAL.instance;
            }
            private set { AddFoodDAL.instance = value; }
        }
        public AddFoodDAL() { }
        public DataTable GetCategories()
        {
            string query = "SELECT CategoryName, CategoryID FROM Category";
            return Database.Instance.ExecuteQuery(query);
        }

        public void SaveFood(Food food)
        {
            
            string query = "INSERT INTO Food (FoodName, Price, IntakePrice, Inventory, CategoryID, Image) VALUES ( @Name , @Price , @IntakePrice , @Inventory , @CategoryID , @Image )";
            Database.Instance.ExecuteNonQuery(query, new object[] { food.FoodName, food.Price, food.IntakePrice, food.Inventory, food.CategoryID, ImageProcess.ImageToByteArray(food.Image) });
        }

        public int GetCategoryID(string categoryName)
        {
            
            string query = "SELECT CategoryID FROM Category WHERE CategoryName = @CatName ";
            return Convert.ToInt32(Database.Instance.ExecuteScalar(query, new object[] { categoryName }));
        }
    }
}
