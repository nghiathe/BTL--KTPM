namespace DAL
{
    public class AddCategoryDAL
    {
        public bool AddCategory(string categoryName)
        {
            int result = Database.Instance.ExecuteNonQuery($"INSERT INTO Category (CategoryName) VALUES (N' {categoryName} ')");

            return result > 0;
        }
    }
}
