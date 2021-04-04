using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    class NewEmployeeExport 
    {
        private readonly ISource _employeeSource;

        public NewEmployeeExport(ISource employeeSource)
        {
            _employeeSource = employeeSource;
        }

        public void ExportEmployees()
        {
            var employeeList = _employeeSource.GetEmployees();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~ Headline ~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("------------------------------------------------");

            foreach(var employee in employeeList)
            {
                Console.Write(employee);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~ Footer ~~~~~~~~~~~~~~~~~~~~");
        }

    }
}
