using SuperList.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperList.Domain.Repositories
{
    public interface IListaDeCompraRepository 
    {
        Task<IList<ListaDeCompraDoUsuarioDTO>> ObterListasDoUsuario(Guid usuarioId);
    }
}
