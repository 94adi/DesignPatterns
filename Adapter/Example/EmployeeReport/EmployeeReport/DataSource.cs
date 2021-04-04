using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class DataSource : IDataSource
    {
        public string[][] GetEntities()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "Id", "Name", "Position", "Salary" };
            employees[1] = new string[] { "1", "John", "Programmer", "5000" };
            employees[2] = new string[] { "2", "Mark", "HW Engineer", "5500" };
            employees[3] = new string[] { "3", "Silvia", "HR", "3500" };

            return employees;
        }
    }
}
