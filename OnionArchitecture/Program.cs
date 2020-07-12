using Microsoft.Extensions.DependencyInjection;
using OniionArchitecture.Core.Entities;
using OniionArchitecture.Core.Entities.ApplicationService;
using OniionArchitecture.Core.Entities.ApplicationService.Services;
using OniionArchitecture.Core.Entities.DomainService;
using OnionArchitecture.Infrastructure.Static.Data.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace OnionArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // var printer = new Printer();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
            serviceCollection.AddScoped<IPrinter, Printer>();


            var serviceProvider = serviceCollection.BuildServiceProvider();

            var printer = serviceProvider.GetRequiredService<IPrinter>();

            printer.UI();
          
        }



    }
}
