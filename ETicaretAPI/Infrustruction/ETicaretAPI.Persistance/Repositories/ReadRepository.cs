using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContext _context; //Henüz IoC conteiner işlemleri yapılmadı

        public ReadRepository(ETicaretAPIDbContext context)//alt+enter kombinasyonu ile açılan menüden constructor inşa ettik.
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>(); // Generic type için set fonksiyonu gerekiyor ve tablo değişkeni için ETicaretAPIDbContext nesnesi kullanıyoruz
        public IQueryable<T> GetAll()
        => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            =>Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)//Bu yüzden bu methodun isminde async kullandık.
            =>await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id)
            //=>await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id)); 
            => await Table.FindAsync(Guid.Parse(id));
    }
}
