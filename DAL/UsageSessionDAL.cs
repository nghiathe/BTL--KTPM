using DTO;
using System.Data;

namespace DAL
{
    public interface IUsageSessionDAL
    {
        UsageSession GetUsageSessionDetails(byte comid);
        void StartSession(byte comId);
        void EndSession(int billId);
        int GetUnCheckOutSession(byte comid);
    }
    public class UsageSessionDAL : IUsageSessionDAL
    {
        private static UsageSessionDAL instance;

        public static UsageSessionDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UsageSessionDAL();
                }
                return UsageSessionDAL.instance;
            }
            private set { UsageSessionDAL.instance = value; }
        }

        private UsageSessionDAL() { }

        public UsageSession GetUsageSessionDetails(byte comid)
        {
            DataTable dt = Database.Instance.ExecuteQuery("GetUsageSessionDetails @comid", new object[] { comid });
            DataRow row = dt.Rows[0];
            return new UsageSession(row);

        }
        public int GetUnCheckOutSession(byte comid)
        {
            DataTable dt = Database.Instance.ExecuteQuery("GetUnCheckOutSession @comid", new object[] { comid });
            if (dt.Rows.Count > 0)
            {
                UsageSession us = new UsageSession(dt.Rows[0]);
                return us.BillId;
            }
            return -1;
        }
        public void StartSession(byte comId)
        {
            Database.Instance.ExecuteNonQuery("ProcBillingINIT @Billingtype", new object[] { 1 });
            Database.Instance.ExecuteNonQuery("ProcUsageSessionINIT @ComputerID", new object[] { comId });

        }
        public void EndSession(int billid)
        {
            string query = string.Format("ProcEndSession @billingid ");
            Database.Instance.ExecuteNonQuery(query, new object[] { billid });
        }
    }
}
