using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistance.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)  // Bir extension metod oluşturduk, bu metodu IOC containerda tanımlıycaz.
        {
            services.AddScoped<IProductService, ProductService>(); //Bu sayede APP.deki abstract metod ile Persistance'daki concrete metodu bağladık.
        }
    }
}
