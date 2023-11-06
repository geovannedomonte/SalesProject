using System.Collections;
using System.Collections.Generic;

namespace SalesProject.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }

        public Department? Department { get; set; }

        public ICollection<SallesRecord> Sales { get; set; } = new List<SallesRecord>();
    }

}
