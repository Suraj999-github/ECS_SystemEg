using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.ServiceClass.CustomerServiceClass;
using ServiceLayer.ServiceClass.PaymentServiceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECSystem
{
    public static class InterFaceInjector
    {
        public static IServiceCollection RegisterAllDependencies(this IServiceCollection services)
        {                   
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IPaymentService, PaymentService>();            
            return services;
        }
    }
}
