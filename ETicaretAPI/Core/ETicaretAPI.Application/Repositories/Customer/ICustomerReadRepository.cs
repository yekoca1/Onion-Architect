using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories //Buradan customer adını silmek gerekli, iki classda da
{
    public interface ICustomerReadRepository : IReadRepository<Customer> //Bu generic olmamalı, çünkü belli
    {

    }
}
