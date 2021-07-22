using System;

namespace ExemploAPI.Business.Entities
{
    public class Endereco : Entity
    {
        public Guid ClienteId { get; private set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public int Numero { get; private set; }

        // EF
        public Cliente Cliente { get; private set; }
    }
}