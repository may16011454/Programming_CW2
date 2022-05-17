using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public class Booking
    {
        public Guid Id { get; set; }

        public string Details { get; set; }

        public DateTime BookingTime { get; set; }

        public Customer Customer { get; set; }

        public Booking(string details, string bookingtime, Customer customer)
        {
            Id = Guid.NewGuid(); 
            Details = details;
            BookingTime = DateTime.Now;
            Customer = customer;
        }
    }
}
