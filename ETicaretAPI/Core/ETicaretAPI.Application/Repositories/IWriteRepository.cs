using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity // insert update işlemleri
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas); //AddAsync fonksiyonu overload edilmişti ama adını değiştirdik.

        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(String id);

        bool Update(T model);
        //Bunların bool olmasının sebebi eklenirse true eklenmezse false dönmesi

        Task<int> SaveAsync();
    }
}
