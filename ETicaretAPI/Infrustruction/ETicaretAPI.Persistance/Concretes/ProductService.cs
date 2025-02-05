using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Concrete
{
    public class ProductService : IProductService  //Abstract nesnenin concrete nesnesini yaptık
    {
        //public List<Product> GetProducts()
        //{
        //    throw new NotImplementedException();
        //}

        public List<Product> GetProducts()
             => new() // Opsiyonel bir tarz, içerisinde sadece product nesneleri oluşturulabilir o yüzden belirtmeye gerek kalmaz!
             {
                 new(){Id = Guid.NewGuid(), Name = "Product 1", Stock = 10, Price = 100},
                 new(){Id = Guid.NewGuid(), Name = "Product 2", Stock = 10, Price = 200},
                 new(){Id = Guid.NewGuid(), Name = "Product 3", Stock = 10, Price = 300},
                 new(){Id = Guid.NewGuid(), Name = "Product 4", Stock = 10, Price = 400},
                 new(){Id = Guid.NewGuid(), Name = "Product 5", Stock = 10, Price = 500},
             };
    }
}
