using EmployeeADONET.BusinessLogic.Interfaces;
using EmployeeADONET.DataAccess;
using EmployeeADONET.Entities;

namespace EmployeeADONET.BusinessLogic
{
    public class EmployeeBL : IEmployeeBL
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeBL()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public List<Employee> GetAll()
        {
            //Logica de Negocio...
            //Unicamente mostrar los empleados que empiece su nombre con s

            return _employeeRepository.GetAll();
        }

        public bool InsertEmployee(Employee employee)
        {
            if (employee is null)
            {
                throw new Exception("No existen los datos del Empleado");
            }

            if (string.IsNullOrEmpty(employee.Name) || string.IsNullOrEmpty(employee.Occupation))
            {
                throw new Exception("No acepto nulos tanto en nombre o en ocupación");
            }

            try
            {
               return _employeeRepository.InsertEmployee(employee);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            

        }
    }
}
