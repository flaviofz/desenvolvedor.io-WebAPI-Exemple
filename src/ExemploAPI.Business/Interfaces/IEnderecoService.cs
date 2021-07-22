using System;
using System.Threading.Tasks;
using ExemploAPI.Business.Entities;

namespace ExemploAPI.Business.Interfaces
{
    public interface IEnderecoService : IDisposable
    {
         Task Adicionar(Endereco endereco);
         Task Atualizar(Endereco endereco);
         Task Remover(Guid id);
    }
}