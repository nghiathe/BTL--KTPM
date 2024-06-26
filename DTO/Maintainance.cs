using System.Data;

namespace DTO
{
    public class Maintainance
    {
        private int maintainId;
        private int billingId;
        private string component;
        private string description;
        public Maintainance(DataRow row)
        {
            this.MaintainId = (int)row["maintainanceid"];
            this.BillingId = (int)row["BillingId"];
            this.Component = row["componentname"].ToString();
            var descriptionTemp = row["description"];
            if (descriptionTemp.ToString() != "")
            {
                this.Description = descriptionTemp.ToString();
            }

        }

        public int BillingId { get => billingId; set => billingId = value; }
        public string Component { get => component; set => component = value; }
        public string Description { get => description; set => description = value; }
        public int MaintainId { get => maintainId; set => maintainId = value; }
    }
}
