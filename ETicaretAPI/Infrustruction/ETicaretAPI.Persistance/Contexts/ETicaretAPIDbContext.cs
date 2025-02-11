using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace ETicaretAPI.Persistance.Contexts//Veri Tabanının bir modeli olacak, o yüzden entityler burada dbset olarak kullanılır
{
    public class ETicaretAPIDbContext: DbContext //EF'ün bir kütüphanesidir.
    {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options) // IOC containerda dolduracağım constructer 
        {}
        public DbSet<Product> Products { get; set; } //Veri tabanında Product entitysine karşılık olarak Products tablosunu oluştur. 
        public DbSet<Order> ORders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

