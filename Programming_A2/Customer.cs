using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public class Customer : IPerson
    {
        public Guid Id { get; set; }

        public string? Fname { get; set; }

        public string? Sname { get; set; }

        public string? Contact { get; set; }
       
        public Customer(string fname, string sname, string contact)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
            Contact = contact;
        }
        public override string? ToString()
        {
            return $"First Name: {Fname} Last Name: {Sname} Contact: {Contact}";
        }
    }
}
