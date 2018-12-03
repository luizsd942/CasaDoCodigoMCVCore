using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRepository
    {
        IList<Cadastro> GetProdutos();
    }
}