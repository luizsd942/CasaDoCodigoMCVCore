using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface IItemPedidoRepository
    {
        IList<ItemPedido> GetProdutos();
    }
}