using System.Collections.Generic;

namespace ExemploAPI.Business.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public int Idade { get; private set; }

        // EF
        public List<Endereco> Enderecos { get; private set; }
    }
}