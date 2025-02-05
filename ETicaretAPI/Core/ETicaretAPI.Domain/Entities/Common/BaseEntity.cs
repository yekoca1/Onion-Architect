using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity //Bütün entitylerde ortak olacak özellikleri burada tanımlıyoruz. Diğer entityler buradan miras alacak.
    {
        public Guid Id { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
