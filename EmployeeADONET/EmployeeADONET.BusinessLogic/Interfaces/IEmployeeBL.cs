using EmployeeADONET.Entities;

namespace EmployeeADONET.BusinessLogic.Interfaces
{
    public interface IEmployeeBL
    {
        List<Employee> GetAll();

        bool InsertEmployee(Employee employee);
    }
}
