using System.Data;

namespace DAL
{
    public class PrintRecipeDAL
    {
        public DataTable GetAllBillings()
        {
            string query = "SELECT * FROM Billing";
            return Database.Instance.ExecuteQuery(query);
        }

        public DataTable GetBillingInfo(int billingID)
        {
            string sql = "Select us.ComputerID, z.ZoneName, z.PricePerHour, us.Duration, us.Cost,us.BillingID, b.BillingDate, e.LastName, b.Amount From Computer as c inner join Zone as z on c.ZoneID = z.ZoneID inner join UsageSession as us on c.ComputerID = us.ComputerID inner join Billing as b on us.BillingID = b.BillingID inner join Employee as e on e.EmployeeID = b.EmployeeID where us.BillingID = @BillingID ";

            return Database.Instance.ExecuteQuery(sql, new object[] { billingID });
        }

        public DataTable GetFoodDetails(int billingID)
        {
            string sql = "SELECT f.FoodName, fd.Count, f.Price, fd.Cost FROM Food AS f INNER JOIN FoodDetail AS fd ON f.FoodID = fd.FoodID WHERE fd.BillingID = @BillingID ";

            return Database.Instance.ExecuteQuery(sql, new object[] { billingID });
        }
    }

}

