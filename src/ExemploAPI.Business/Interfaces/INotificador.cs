using System.Collections.Generic;
using ExemploAPI.Business.Notificacoes;

namespace ExemploAPI.Business.Interfaces
{
    public interface INotificador
    {
         bool TemNotificacao();
         List<Notificacao> ObterNotificacoes();
         void Handle(Notificacao notificacao);
    }
}