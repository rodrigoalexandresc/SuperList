using SuperList.Domain;
using SuperList.Domain.Commands;
using SuperList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperList.Services
{
    public interface IListaDeCompraService
    {
        Task CriarListaDeCompra(CriarListaDeCompraCommand command);

        Task IncluirItem(IncluirItemListaDeCompraCommand command);
    }
}
