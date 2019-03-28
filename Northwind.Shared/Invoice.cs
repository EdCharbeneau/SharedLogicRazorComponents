using System;
using System.ComponentModel.DataAnnotations;
namespace Northwind.Shared
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        [Key]
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public string Salesperson { get; set; }

    }
}