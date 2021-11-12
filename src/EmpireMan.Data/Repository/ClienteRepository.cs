using EmpireMan.Business.Interfaces;
using EmpireMan.Business.Models;
using EmpireMan.Data.Context;

namespace EmpireMan.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(EmpireDbContext context) : base(context) {}
    }
}
