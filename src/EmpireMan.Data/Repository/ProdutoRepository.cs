using EmpireMan.Business.Interfaces;
using EmpireMan.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpireMan.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public async Task<IEnumerable<Produto>> ObtemProdutosPorCategoria(int idCategoria)
        {
            return await Db?.Produtos.AsNoTracking().Where(x => x.CategoriaId == idCategoria).ToListAsync();
        }
    }
}
