using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity // en temel kapsayıcı repository 
    {
        //Normalde DbSet<Product> tarzı yazılır ama ben genel olmasını istiyorum. Bu yüzden generic yapıcam ve dbset sadece class parametresi kabul ettiği için de Tyi şartladık..!
        DbSet<T> Table { get; }  
    }
}
