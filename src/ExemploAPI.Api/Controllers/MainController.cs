using System.Linq;
using ExemploAPI.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAPI.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida() => 
            !_notificador.TemNotificacao();

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
                return Ok(new
                {
                    success = true,
                    data = result
                });

            return BadRequest(new
            {
                success = false,
                errors = _notificador.ObterNotificacoes().Select(m => $"{m.Campo} - {m.Mensagem}")
            });
        }
    }
}