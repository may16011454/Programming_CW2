using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public class Services
    {
        public Guid Id { get; set; }

        public string Details { get; set; }

        public bool isOpen { get; set; } 

        public DateTime TimeStarted { get; set; }

        public DateTime TimeFinished { get; set; }


        public Services(string details, bool isopen)
        {
            Id = Guid.NewGuid();
            Details = details;
            isOpen = false;
            TimeStarted = DateTime.Now;
            TimeFinished = DateTime.Now;
        }
        public override string? ToString()
        {
            return $"Details: {Details} Is Service Open: {isOpen} Time Started: {TimeStarted} Time Finished: {TimeFinished} ";
        }
    }
}
