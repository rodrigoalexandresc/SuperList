using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperList.Domain
{
    public class ListaDeCompra
    {
        public ListaDeCompra(Guid usuarioId)
        {
            Id = Guid.NewGuid();
            UsuarioId = usuarioId;
            Status = StatusDaListaDeCompraEnum.Aberta;
            DataCriacao = DateTime.Now;
            Itens = new List<ItemDaListaDeCompra>();
        }

        public Guid Id { get; private set; }

        public Guid UsuarioId { get; private set; }

        public bool ListaPadrao { get; private set; }

        public DateTime? DataCriacao { get; private set; }

        public DateTime? DataCompra { get; private set; }

        public StatusDaListaDeCompraEnum Status { get; set; }

        public IList<ItemDaListaDeCompra> Itens { get; private set; }

        public void IncluirItem(Guid produtoId, decimal qtdeComprar)
        {
            var item = Itens.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (item != null)
                item.AdicionarQuantidade(qtdeComprar);
            else 
                Itens.Add(new ItemDaListaDeCompra(produtoId, qtdeComprar));
        }
    }
}
