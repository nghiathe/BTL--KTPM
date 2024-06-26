using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class ComputerDAL
    {
        private static ComputerDAL instance;

        public static ComputerDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ComputerDAL();
                }
                return ComputerDAL.instance;
            }
            private set { ComputerDAL.instance = value; }
        }

        public static int ComWidth = 83;
        public static int ComHeight = 83;

        private ComputerDAL() { }

        public List<Computer> LoadFullCom()
        {
            List<Computer> com = new List<Computer>();
            DataTable dt = Database.Instance.ExecuteQuery("select computerid, computername, computerstatus from computer");
            foreach (DataRow dr in dt.Rows)
            {
                Computer ban = new Computer(dr);
                com.Add(ban);
            }
            return com;
        }

        public DataTable GetComs(byte zoneid)
        {
            return Database.Instance.ExecuteQuery($"Select computerid, computername from Computer where zoneid = {zoneid}");
        }
    }
}
