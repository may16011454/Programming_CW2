using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Programming_A2.Enums;

namespace Programming_A2
{
    public class StaffMember : IPerson, IStaff
    {

        public Guid Id { get; set; }

        public string Fname { get; set; }

        public string Sname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Contact { get; set; }

        public StaffType Type { get; set; }

        public StaffMember(string fname, string sname, string username, string password, StaffType type)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
            Username = username;
            Password = password;
            Type = type;
        }

        public override string? ToString()
        {
            return $"First Name: {Fname} Last Name: {Sname} Username: {Username} Password: ************ Type: {Type}";
        }
    }
}
