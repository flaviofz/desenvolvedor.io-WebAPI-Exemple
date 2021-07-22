using System;
using System.Threading.Tasks;
using ExemploAPI.Business.Entities;

namespace ExemploAPI.Business.Interfaces
{
    public interface IClienteService : IDisposable
    {
         Task Adicionar(Cliente cliente);
         Task Atualizar(Cliente cliente);
         Task Remover(Guid id);
    }
}