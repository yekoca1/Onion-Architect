﻿using ETicaretAPI.Domain.Entities; //Burası önemli
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions
{
    public interface IProductService
    {
        public List<Product> GetProducts();

    }
}
