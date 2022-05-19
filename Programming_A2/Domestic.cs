using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Programming_A2.Enums;

namespace Programming_A2
{
    public class Domestic : IProperties
    {
        public Guid Id { get; set; }
        public string Address { get; set; }

         public Customer CurrentCustomer { get; set; }
        public List<IIssue> Issues { get; set; }

        public DomesticType Type { get; set; }
        public int NumberOfRooms { get; set; }

        public Domestic(string? address, Customer? currentCustomer, DomesticType type, int numberOfRooms)
        {
            Address = address;
            CurrentCustomer = currentCustomer;
            Type = type;
            NumberOfRooms = numberOfRooms;
        }

        public override string? ToString()
        {
            return $"Address: {Address} Number of Rooms: {NumberOfRooms} Type: {Type}";
        }
    }
}
