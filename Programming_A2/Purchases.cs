using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public class Purchases
    {
        public Guid Id { get; set; }

        public string? Description { get; set; }

        public double Cost { get; set; }

        public DateTime CreatedOn { get; set; }

        public StaffMember? CreatedBy { get; set; }

        public Purchases(string? description, double cost, StaffMember? createdBy)
        {
            Id = Guid.NewGuid();
            Description = description; 
            Cost = cost;
            CreatedOn = DateTime.Now;
            CreatedBy = createdBy;
        }
        public override string? ToString()
        {
            return $"Description: {Description} Cost: £{Cost} Date Purchased: {CreatedOn}";
        }
    }
}
