using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto, DbSet<T> dbSet)
        {
            this.contexto = contexto;
            this.dbSet = dbSet;
        }
    }
}
