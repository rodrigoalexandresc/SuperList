using Raven.Client;
using SuperList.Domain;
using SuperList.Domain.DTO;
using SuperList.Domain.Infra;
using SuperList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperList.Infra.Repository.RavenDB
{
    public class ListaDeCompraRepository : RavenDBRepository, IListaDeCompraRepository
    {
        IAsyncDocumentSession session;

        public ListaDeCompraRepository(IUnitOfWorkRavenDB uow) : base(uow)
        {
            session = ((UnitOfWorkRavenDB)uow).Session;
        }

        public async Task<IList<ListaDeCompraDoUsuarioDTO>> ObterListasDoUsuario(Guid usuarioId)
        {
            return await session.Query<ListaDeCompra>()
                .Where(o => o.UsuarioId == usuarioId)
                .Select(o => new ListaDeCompraDoUsuarioDTO
                {
                    Id = o.ListaDeCompraId,
                    DataCriacao = o.DataCriacao
                }).ToListAsync();
                
        }
    }
}
