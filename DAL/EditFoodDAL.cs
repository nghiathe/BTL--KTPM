using DTO;
using System.Data;

namespace DAL
{
    public class EditFoodDAL
    {
        private static EditFoodDAL instance;

        public static EditFoodDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditFoodDAL();
                }
                return EditFoodDAL.instance;
            }
            private set { EditFoodDAL.instance = value; }
        }
        public EditFoodDAL () { }
        public DataTable GetAllFood()
        {
            string query = "SELECT foodid, foodname, price, intakeprice, inventory, categoryid, image FROM Food";
            return Database.Instance.ExecuteQuery(query);
        }

        public void DeleteFood(int foodID)
        {
            string query = "DELETE FROM Food WHERE FoodID = @ID";
            Database.Instance.ExecuteNonQuery(query, new object[] { foodID });
        }

        public void UpdateFood(Food food, bool imageUpdated)
        {
            string query;
            if (imageUpdated)
            {
                query = "UPDATE Food SET FoodName = @Name , Price = @Price , IntakePrice = @IntakePrice , Inventory = @Inventory , Image = @Image , CategoryId = @catID WHERE FoodID = @ID ";
                Database.Instance.ExecuteNonQuery(query, new object[] { food.FoodName, food.Price, food.IntakePrice, food.Inventory, ImageProcess.ImageToByteArray(food.Image), food.CategoryID, food.FoodID });
            }
            else
            {
                query = "UPDATE Food SET FoodName = @Name , Price = @Price , IntakePrice = @IntakePrice , Inventory = @Inventory , CategoryId = @catID WHERE FoodID = @ID ";
                Database.Instance.ExecuteNonQuery(query, new object[] { food.FoodName, food.Price, food.IntakePrice, food.Inventory, food.CategoryID, food.FoodID });
            }
        }

    }
}
