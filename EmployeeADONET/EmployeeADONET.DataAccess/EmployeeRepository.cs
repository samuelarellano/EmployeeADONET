


using EmployeeADONET.Entities;
using System.Data;

namespace EmployeeADONET.DataAccess;

public class EmployeeRepository : IEmployeeRepository
{
    public const string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public bool DeleteEmployee(int id)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetAll()
    {
        List<Employee> employees = new List<Employee>();

        using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
        {
            try
            {
                connection.Open();

                //string query = "SELECT id, name, occupation from Employee";
                string query = "spSeleccionarEmpleado";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = reader.GetInt32(0);
                            //employee.Name = reader.GetString(1);
                            employee.Occupation = reader.GetString(2);

                            employee.Name = reader["name"].ToString() is null ? string.Empty : reader["name"].ToString();

                            employees.Add(employee);
                        }

                        return employees;

                    }
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }

    public Employee GetEmployee(int id)
    {
        throw new NotImplementedException();
    }

    public bool InsertEmployee(Employee employee)
    {
        
        List<Employee> employees = new List<Employee>();

        using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Employee (name, occupation) VALUES (@name, @occupation)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", employee.Name);
                    command.Parameters.AddWithValue("@occupation", employee.Occupation);
                    var result = (int) command.ExecuteNonQuery();

                    return result > 0;
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }


    public bool UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }
}
