using System;
namespace Northwind.Shared
{
    public class OrderSearchCriteria
    {
        public int EmployeeId { get; set; }
        public string SalesPerson { get; set; }
        public DateTime StatsFrom { get; set; }
        public DateTime StatsTo { get; set; }

    }
}