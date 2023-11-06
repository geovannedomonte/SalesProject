using SalesProject.Models.Enums;

namespace SalesProject.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        public Seller? Seller { get; set; }
    }
}
