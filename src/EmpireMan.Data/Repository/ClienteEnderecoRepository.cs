using EmpireMan.Business.Interfaces;
using EmpireMan.Business.Models;
using EmpireMan.Data.Context;

namespace EmpireMan.Data.Repository
{
    public class ClienteEnderecoRepository : Repository<ClienteEndereco>, IClienteEnderecoRepository
    {
        public ClienteEnderecoRepository(EmpireDbContext context) : base(context) {}
    }
}
