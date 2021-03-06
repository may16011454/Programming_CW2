using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public class Enums
    {
        public enum CommericalType
        {
            OFFICE,
            WAREHOUSE,
            FACTORY,
            INDUSTRIAL_UNIT,
            RETAIL
        }

        public enum DomesticType
        {
            HOUSE,
            FLAT,
            BUNGALOW
        }

        public enum StaffType
        {
            ADMIN,
            MANAGER,
            TEAM_MEMBER,
            CLEANER
        }

        public enum IssueSeverity
        { 
            NOT_MUCH_OF_AN_ISSUE ,
            BAD,
            URGENT,
            MINOR,
            MAJOR
        }

    }
}
