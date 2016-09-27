using SuperList.Domain;
using SuperList.Domain.Commands;
using SuperList.Domain.Repositories;
using SuperList.Services;
using System.Threading.Tasks;

namespace SuperList.Application
{
    public class ListaDeCompraService : IListaDeCompraService
    {
        readonly IListaDeCompraRepository listaDeCompraRepository;

        public ListaDeCompraService(IListaDeCompraRepository listaDeCompraRepository)
        {
            this.listaDeCompraRepository = listaDeCompraRepository;
        }

        public async Task CriarListaDeCompra(CriarListaDeCompraCommand command)
        {
            var listaDeCompra = new ListaDeCompra(command.UsuarioId);
            await listaDeCompraRepository.SaveAsync(listaDeCompra);
        }

        public async Task IncluirItem(IncluirItemListaDeCompraCommand command)
        {
            var listaDeCompra = await listaDeCompraRepository.FindAsync(command.ListaDeCompraId);
            listaDeCompra.IncluirItem(command.ProdutoId, command.Quantidade);
            await listaDeCompraRepository.SaveAsync(listaDeCompra);
        }
    }
}
