using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    internal class CleaningSystem
    {
        public string Name { get; set; }

        public List<IProperties> Properties { get; set; }
        public List<IPerson> People { get; set; }
        public List<Booking> BookingInfo { get; set; }
        public List<Customer> CustomerInfo { get; set; }
        public List<StaffMember> StaffInfo { get; set; }
        public List<Domestic> DomesticInfo { get; set; }
        public List<Commercial> CommercialInfo { get; set; }
        public List<Purchases> PurchaseInfo{ get; set; }
        public List<Major> IssueInfo{ get; set; }

        public CleaningSystem(string name)
        {
            Name = name;
            Properties = new List<IProperties>();
            People = new List<IPerson>();  
            BookingInfo = new List<Booking>();
            CustomerInfo = new List<Customer>();
            StaffInfo = new List<StaffMember>();
            DomesticInfo = new List<Domestic>();
            CommercialInfo = new List<Commercial>();
            PurchaseInfo = new List<Purchases>();
            IssueInfo = new List<Major>();
        }
    }
}
