using SuperList.Domain.Commands;
using SuperList.Domain.Services;
using System;
using System.Web.Http;

namespace SuperList.API.Controllers
{
    public class DispensaController : ApiController
    {
        readonly IDispensaService dispensaService;

        public DispensaController(IDispensaService dispensaService)
        {
            this.dispensaService = dispensaService;
        }

        //[HttpGet]
        //public 

        [HttpPost]
        public void CadastrarDispensa(Guid usuarioId)
        {
            dispensaService.Cadastrar(new CadastrarDispensaCommand(usuarioId));
        }

    }
}
