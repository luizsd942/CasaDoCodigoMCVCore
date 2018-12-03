using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto, DbSet<ItemPedido> dbSet) : base(contexto, dbSet)
        {
        }

        public IList<ItemPedido> GetProdutos()
        {
            return dbSet.ToList();
        }
    }
}
