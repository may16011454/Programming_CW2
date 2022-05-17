using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_A2
{
    internal class Commercial : IProperties
    {
        public Guid Id { get; set; }
        public string? Address { get; set; }

        public Customer? CurrentCustomer { get; set; }

        public List<IIssue>? Issues { get; set; }

        public double Size { get; set; }

        public Commercial (string address, double size)
        {
            Id = Guid.NewGuid();
            Address = address;
            Issues = new List<IIssue>();
            Size = size;
        }

        public override string? ToString()
        {
            return $"Address: {Address} Customer: {CurrentCustomer} Size: {Size}";
        }
    }
}
