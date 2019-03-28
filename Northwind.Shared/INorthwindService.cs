using System.Collections.Generic;
using System.Threading.Tasks;

namespace Northwind.Shared
{
    public interface INorthwindService
    {
        Task<List<Employee>> GetAllEmployeesAsync();
    }
}