using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    public class Cosmetic
    {
        public Guid Id { get; set; }

        public string? Description { get; set; }

        public DateTime Timestamp { get; set; }

        public List<Purchases>? Purchases { get; set; }

        public Cosmetic(string? description, DateTime timestamp)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = timestamp;
            Purchases = new List<Purchases>();
        }
        public override string? ToString()
        {
            return $"Description: {Description} Time Stamp: {Timestamp}";
        }
    }
}
