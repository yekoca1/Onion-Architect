﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public DateTime CreatedTime;

        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
    }
}
