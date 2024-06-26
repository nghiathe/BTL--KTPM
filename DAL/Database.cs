using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public interface IDatabase
    {
        DataTable ExecuteQuery(string query, params object[] parameters);
        object ExecuteScalar(string query, params object[] parameters);
        int ExecuteNonQuery(string query, params object[] parameters);
    }
    public class Database : IDatabase
    {

        #region ---------- Code cua HungTuLenh 
        private static IDatabase instance;

        public static IDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
            set { instance = value; }
        }
        public static void SetInstance(IDatabase newInstance)
        {
            instance = newInstance;
        }


        //private string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=QlyCafeInternet;Integrated Security=True";
        private string connectionSTR = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=QlQN;Integrated Security=True";
        //private string connectionSTR = "Data Source=LAPTOP-KKNF42CS\\SQLEXPRESS;Initial Catalog=QLyCafeInternet;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(query, cn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                cn.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(query, cn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cm.ExecuteNonQuery();
                cn.Close();
            }
            return dt;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dt = 0;
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(query, cn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cm.ExecuteScalar();
                cn.Close();
            }
            return dt;
        }
        #endregion


    }

}
