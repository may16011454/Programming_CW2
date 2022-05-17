using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Programming_A2.Enums;

namespace Programming_A2
{
    public class Major
    {
        public Guid Id { get; set; }

        public string? Description { get; set; }

        public DateTime Timestamp { get; set; }

        public IssueSeverity Severity { get; set; }
        public List<Purchases>? Purchases { get; set; }

        public Major(Guid id, string? description, DateTime timestamp, IssueSeverity severity)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = timestamp;
            Purchases = new List<Purchases>();
        }
    }
}
