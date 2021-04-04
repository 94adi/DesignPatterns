using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public static class DI
    {
        public static void RegisterService(ref ServiceProvider serviceProvider)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IDataSource, DataSource>();
            services.AddSingleton<IExportTool, OldEmployeeExport>();
            //services.AddSingleton<IExportTool, ExportAdapter>();
            serviceProvider = services.BuildServiceProvider(true);
        }

        public static void DisposeServices(ref ServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                return;
            }
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }
    }
}
