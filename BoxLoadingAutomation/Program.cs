using BoxLoadingAutomation.Behaviour;
using BoxLoadingAutomation.Factory;
using BoxLoadingAutomation.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLoadingAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating service collection for dependecies registration
            IServiceCollection serviceCollection = new ServiceCollection();
            var ServiceProvider = RegisterDependencies(serviceCollection);

            do
            {
                Console.WriteLine("Select User Story: ");
                var story = Console.ReadLine();

                switch (story)
                {
                    case "1":
                        var planeService = ServiceProvider.GetService<IPlaneService>();
                        planeService.PrintSchedule();
                        break;

                    case "2":
                        var orderService = ServiceProvider.GetService<IOrderService>();
                        orderService.Process();
                        orderService.PrintOrders();
                        break;
                    default:
                        Console.WriteLine("Enter Valid User Story Option:");
                        Console.WriteLine("1 - To Load Flight Schedule");
                        Console.WriteLine("2 - Process Batch Of Orders");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter To Continue...");
                Console.ReadLine();
            } while(true);
        }

        private static ServiceProvider RegisterDependencies(IServiceCollection serviceDescriptors)
        {
            return serviceDescriptors
            .AddSingleton<IPlaneService, PlaneService>()
            .AddSingleton<IOrderService, OrderService>()
            .AddSingleton<IOrderFactory, OrderFactory>()
            .AddSingleton<IPlaneFactory, PlaneFactory>()
            .BuildServiceProvider();
        }
    }
}
