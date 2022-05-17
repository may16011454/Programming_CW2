using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Programming_A2.Enums;

namespace Programming_A2
{
    public interface IStaff
    {
        public string Username { get; set; }
        
        public string Password { get; set; }

        public StaffType Type { get; set; }

        public List<Booking> Booking { get; set; }

        public List<Purchases> Purchase { get; set; }
         
        public List<Services> Service { get; set; }
    }
}
