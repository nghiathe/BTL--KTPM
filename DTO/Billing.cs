using System;
using System.Data;

namespace DTO
{

    public class Billing
    {
        private DateTime bDate;
        private string emName;
        private byte bType;
        private decimal sCost;
        private decimal mCost;
        private decimal fCost;
        private decimal amount;
        public Billing(DataRow row)
        {
            this.BDate = (DateTime)row["billingdate"];
            this.EmName = row["employeename"].ToString();
            this.BType = (byte)row["billingtype"];
            this.SCost = (decimal)row["sessioncost"];
            this.MCost = (decimal)row["maintainancecost"];
            this.FCost = (decimal)row["foodcost"];
            this.Amount = (decimal)row["amount"];
        }

        public DateTime BDate { get => bDate; set => bDate = value; }
        public string EmName { get => emName; set => emName = value; }
        public byte BType { get => bType; set => bType = value; }
        public decimal SCost { get => sCost; set => sCost = value; }
        public decimal MCost { get => mCost; set => mCost = value; }
        public decimal FCost { get => fCost; set => fCost = value; }
        public decimal Amount { get => amount; set => amount = value; }
    }
    public class BillingPrint
    {
        private string billingID;
        private DateTime dateTime;
        private string lastName;
        private decimal amount;
        public string BillingID { get => billingID; set => billingID = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public decimal Amount { get => amount; set => amount = value; }
    }

}
