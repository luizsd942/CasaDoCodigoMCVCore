using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface IPedidoRepository
    {
        IList<ItemPedido> GetProdutos();
    }
}