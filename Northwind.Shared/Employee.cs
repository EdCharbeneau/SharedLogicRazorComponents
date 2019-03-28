using System.Collections.Generic;
namespace Northwind.Shared
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public int? ReportsTo { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string HomePhone { get; set; }
        public string Notes { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public Employee Manager { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
