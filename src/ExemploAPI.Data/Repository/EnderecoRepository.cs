using ExemploAPI.Business.Entities;
using ExemploAPI.Business.Interfaces;
using ExemploAPI.Data.Context;

namespace ExemploAPI.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuContext context) : base(context) { }
    }
}