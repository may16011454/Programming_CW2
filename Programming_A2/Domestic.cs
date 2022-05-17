using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    internal class Domestic : IProperties
    {
        public Guid Id { get; set; }
        public string? Address { get; set; }

         public Customer? CurrentCustomer { get; set; }
        public List<IIssue>? Issues { get; set; }

        public DomesticType Type { get; set; }
        public int NumberOfRooms { get; set; } 
    }
}
