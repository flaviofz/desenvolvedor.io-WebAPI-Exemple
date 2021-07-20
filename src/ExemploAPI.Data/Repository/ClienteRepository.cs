using ExemploAPI.Business.Entities;
using ExemploAPI.Business.Interfaces;
using ExemploAPI.Data.Context;

namespace ExemploAPI.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(MeuContext context) : base(context) { }
    }
}