using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity  //query/select işlemleri
    {
        IQueryable<T> GetAll(); // IQueryable sorgu yaparken önemli

        IQueryable<T> GetWhere(Expression<Func<T, bool>> method); //where şartını koyabilmek için ORM sentaksı kullandık.

        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);//Asenkron fonksiyon olacağı için bunu belirttik
        Task<T> GetByIdAsync(string id);

    }
}
