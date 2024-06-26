using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public interface IBillingDAL
    {
        void CheckOut(int billid, byte emid);
    }
    public class BillingDAL : IBillingDAL
    {
        private static BillingDAL instance;

        public static BillingDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillingDAL();
                }
                return BillingDAL.instance;
            }
            private set { BillingDAL.instance = value; }
        }
        private BillingDAL() { }

        public List<Billing> loadBillList(DateTime ngaybd, DateTime ngaykt)
        {
            List<Billing> bl = new List<Billing>();
            string query = "GetBillByDate @ngaybd , @ngaykt";
            DataTable dt = Database.Instance.ExecuteQuery(query, new object[] { ngaybd, ngaykt });
            foreach (DataRow dr in dt.Rows)
            {
                Billing hd = new Billing(dr);
                bl.Add(hd);
            }
            return bl;
        }

        public void CheckOut(int billid, byte emid)
        {
            string query = string.Format("ProcCheckOut @billingid , @employeeid");
            Database.Instance.ExecuteNonQuery(query, new object[] { billid, emid });
        }

        public void CheckOutMaintainance(int billid, byte emid, decimal cost, byte comid)
        {
            string nonquery = string.Format("UPDATE Maintainance SET Cost = {0} WHERE billingid = {1}", cost, billid);
            Database.Instance.ExecuteNonQuery(nonquery);
            string query = string.Format("ProcCheckOut @billingid , @employeeid");
            Database.Instance.ExecuteNonQuery(query, new object[] { billid, emid });
            Database.Instance.ExecuteNonQuery("ProcComputerStatus @computerID , 0", new object[] { comid });
        }
        public int GetMaxBillingID()
        {
            return (int)Database.Instance.ExecuteScalar("Select max(billingid) from billing");
        }
        public void CheckOutFoodIntake(byte foodId, int count)
        {
            Database.Instance.ExecuteNonQuery("Exec ProcBillingINIT 0");
            int billid = GetMaxBillingID();
            Database.Instance.ExecuteNonQuery($"Insert into FoodDetail(Billingid, foodid, count) values ({billid},{foodId}, {count})");
            Database.Instance.ExecuteNonQuery("Exec ProcCheckOut @billingid , @employeeid", new object[] {billid, Employee.emId});
        }
    }
}

