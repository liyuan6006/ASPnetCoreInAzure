using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreinAzure.Models
{
    public class AddressLabel
    {
        private int lCustomerID;
        private string sTitle;
        private string sFirstName;
        private string sLastName;
        private string sAddressLine1;

        public AddressLabel(int lCustomerID, string sTitle, string sFirstName, string sLastName, string sAddressLine1)
        {
            this.LCustomerID = lCustomerID;
            this.STitle = sTitle;
            this.SFirstName = sFirstName;
            this.SLastName = sLastName;
            this.SAddressLine1 = sAddressLine1;
        }

        public int LCustomerID { get => lCustomerID; set => lCustomerID = value; }
        public string STitle { get => sTitle; set => sTitle = value; }
        public string SFirstName { get => sFirstName; set => sFirstName = value; }
        public string SLastName { get => sLastName; set => sLastName = value; }
        public string SAddressLine1 { get => sAddressLine1; set => sAddressLine1 = value; }
    }
}
