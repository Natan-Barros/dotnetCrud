using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCrud.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSet;
        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            this.dbSet = contexto.Set<T>();
        }
    }
}