using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeADONET.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        bool InsertEmployee(Employee employee);

        bool UpdateEmployee(Employee employee);

        bool DeleteEmployee(int id);

        Employee GetEmployee(int id);
        List<Employee> GetAll();
    }
}
