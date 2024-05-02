using EmployeeADONET.BusinessLogic;
using EmployeeADONET.Entities;

namespace EmployeeADONET.WindowsUI
{
    public partial class Form1 : Form
    {
        private EmployeeBL _employeeBL;

        public Form1()
        {
            InitializeComponent();
            _employeeBL = new EmployeeBL();
        }

        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            var employees = _employeeBL.GetAll();
            lstEmployees.Items.Clear();
            lstEmployees.Items.AddRange(employees.ToArray());
            lstEmployees.DisplayMember = "Name";
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                Name = textBox1.Text,
                Occupation = textBox2.Text,
            };

            try
            {
                if (_employeeBL.InsertEmployee(employee))
                {
                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
