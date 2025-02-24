<<<<<<< Updated upstream
﻿using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistance.Concrete;
=======
﻿using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistance.Contexts;
>>>>>>> Stashed changes
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistance.Repositories;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)  // Bir extension metod oluşturduk, bu metodu IOC containerda tanımlıycaz.
        {
<<<<<<< Updated upstream
            services.AddScoped<IProductService, ProductService>(); //Bu sayede APP.deki abstract metod ile Persistance'daki concrete metodu bağladık.
=======
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString)); //Burada ETicaretAPIDbContext sınıfını IoC conteiner'a eklemişiz  

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>(); // 1. istendiğinde 2.yi döndür
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
>>>>>>> Stashed changes
        }
    }
}
