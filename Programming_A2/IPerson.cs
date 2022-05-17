using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public interface IPerson
    {
        public Guid Id { get; set; }

        public string Fname { get; set; }

        public string Sname { get; set; }

        public string Contact{ get; set; } 
    }
}
