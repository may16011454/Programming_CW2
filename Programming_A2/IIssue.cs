using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public interface IIssue
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime Timestamp { get; set; }

        public List<Purchases> Purchases { get; set; } 

    }

}
