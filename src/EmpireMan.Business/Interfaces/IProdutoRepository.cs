using EmpireMan.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpireMan.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObtemProdutosPorCategoria(int idCategoria);
    }
}
