using SuperList.Domain.DTO;
using SuperList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace SuperList.API.Controllers
{
    public class ListaDeCompraController : ApiController
    {
        readonly IListaDeCompraRepository listaDeCompraRepository;

        public ListaDeCompraController(IListaDeCompraRepository listaDeCompraRepository)
        {
            this.listaDeCompraRepository = listaDeCompraRepository;
        }

        [HttpGet]
        public async Task<IList<ListaDeCompraDoUsuarioDTO>> ObterListasDoUsuario(Guid usuarioId)
        {
            return await listaDeCompraRepository.ObterListasDoUsuario(usuarioId);
        }
    }
}
