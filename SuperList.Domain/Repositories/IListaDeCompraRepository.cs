using SuperList.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperList.Domain.Repositories
{
    public interface IListaDeCompraRepository : IRepository<ListaDeCompra>
    {
        Task<IList<ListaDeCompraDoUsuarioDTO>> ObterListasDoUsuario(Guid usuarioId);


    }
}
