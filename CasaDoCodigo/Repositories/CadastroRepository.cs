using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto, DbSet<Cadastro> dbSet) : base(contexto, dbSet)
        {
        }

        public IList<Cadastro> GetProdutos()
        {
            return dbSet.ToList();
        }
    }
}
