using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class OldEmployeeExport : IExportTool
    {
        private readonly IDataSource _ds;
        public OldEmployeeExport(IDataSource ds)
        {
            _ds = ds;
        }

        public void Export()
        {
            var employees = _ds.GetEntities();

            foreach (var employee in employees)
            {
                foreach (var column in employee)
                {
                    Console.Write(column + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
