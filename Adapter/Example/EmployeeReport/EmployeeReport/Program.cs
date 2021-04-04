using System;
using Microsoft.Extensions.DependencyInjection;
namespace EmployeeReport
{
    class Program
    {
        private static ServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            DI.RegisterService(ref _serviceProvider);
            IServiceScope scope = _serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<IExportTool>().Export();
            DI.DisposeServices(ref _serviceProvider);
        }


    }
}
