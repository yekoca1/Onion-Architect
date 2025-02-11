using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order: BaseEntity
    {
        public int CustomerID { get; set; } // EF customer ile customer idyi ilişkilendirecektir.
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; } // Bir order birden fazla producta sahip olabilir!!!
        public Customer Customer { get; set; }  // Bir order sadece bir tane customera sahip olabilir!!!

    }
}
