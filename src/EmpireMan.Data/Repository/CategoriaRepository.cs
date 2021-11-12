using EmpireMan.Business.Interfaces;
using EmpireMan.Business.Models;
using EmpireMan.Data.Context;

namespace EmpireMan.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(EmpireDbContext context) : base(context) {}
    }
}
