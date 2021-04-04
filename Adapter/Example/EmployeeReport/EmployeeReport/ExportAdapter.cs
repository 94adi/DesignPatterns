using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class ExportAdapter : IExportTool , ISource
    {
        private NewEmployeeExport newExportTool;
        private readonly IDataSource _ds;
        public ExportAdapter(IDataSource ds)
        {
            _ds = ds;
            newExportTool = new NewEmployeeExport(this);
        }

        public IEnumerable<string> GetEmployees()
        {
            var employeeList = new List<string>();

            var oldEmployeeList = _ds.GetEntities();

            employeeList = ConvertOldEmployees(oldEmployeeList);

            return employeeList;
        }

        private List<string> ConvertOldEmployees(string[][] oldEmployees)
        {
            var employeeList = new List<string>();
            foreach(var oldEmployee in oldEmployees)
            {
                employeeList.Add("\n");
                employeeList.Add(oldEmployee[0]);
                employeeList.Add(AddSpaces(oldEmployee[0].Length, 5));
                employeeList.Add("| ");
                employeeList.Add(oldEmployee[1]); employeeList.Add(AddSpaces(oldEmployee[1].Length, 10));
                employeeList.Add("| ");
                employeeList.Add(oldEmployee[2]);
                employeeList.Add(AddSpaces(oldEmployee[2].Length, 15));
                employeeList.Add("| ");
                employeeList.Add(oldEmployee[3]);
                employeeList.Add(AddSpaces(oldEmployee[3].Length, 10));
                employeeList.Add("| ");
                employeeList.Add("\n");
                
            }

            return employeeList;
        }

        private string AddSpaces(int charsInCol, int maxLength)
        {
            StringBuilder result = new StringBuilder();

            for (var i = charsInCol; i < maxLength; i++) result.Append(" ");

            return result.ToString();
        }

        public void Export()
        {
            newExportTool.ExportEmployees();
        }


    }
}
