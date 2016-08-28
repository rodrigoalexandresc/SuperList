using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperList.Domain
{
    public class ListaDeCompra
    {
        public Guid ListaDeCompraId { get; private set; }

        public Guid UsuarioId { get; private set; }

        public Guid DispensaId { get; private set; }

        public DateTime? DataCriacao { get; private set; }

        public DateTime? DataCompra { get; private set; }

        public StatusDaListaDeCompraEnum Status { get; set; }

        public IList<ItemDaListaDeCompra> Itens { get; private set; }

        public void CriarNovaCompra()
        {
            Status = StatusDaListaDeCompraEnum.Aberta;
            DataCriacao = DateTime.Now;
        }

        public void IncluirItem(Guid produtoId, decimal qtdeComprar)
        {
            if (Itens.Any(p => p.ProdutoId == produtoId))
                throw new Exception("Produto já incluso na lista");

            Itens.Add(new ItemDaListaDeCompra(produtoId, qtdeComprar));
        }

        public void MarcarItemComoComprado(Guid produtoId)
        {            
            ObterItem(produtoId).MarcarItemComoComprado();
        }

        public void AdicionarQuantidadeComprada(Guid produtoId, decimal qtde)
        {
            ObterItem(produtoId).AdicionarQtdeComprada(qtde);
        }

        public void SetarPrecoDeItem(Guid produtoId, decimal preco)
        {
            ObterItem(produtoId).SetarPreco(preco);
        }

        public ItemDaListaDeCompra ObterItem(Guid produtoId)
        {
            var item = Itens.First(o => o.ProdutoId == produtoId);
            if (item == null)
                throw new Exception("Item não encontrado na lista");

            return item;
        }

        public void IniciarCompra()
        {
            Status = StatusDaListaDeCompraEnum.Comprando;
            DataCompra = DateTime.Now;
        }

        public void Finalizar()
        {
            Status = StatusDaListaDeCompraEnum.Finalizada;
        }
    }
}
