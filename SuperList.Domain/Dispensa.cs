using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperList.Domain
{
    public class Dispensa
    {        
        public Guid DispensaId { get; private set; }

        public Guid UsuarioId { get; private set; }

        public IList<ItemDaDispensa> Itens { get; private set; }

        public void CriarDispensa(Guid dispensaId, Guid usuarioId)
        {
            DispensaId = dispensaId;
            UsuarioId = UsuarioId;
            Itens = new List<ItemDaDispensa>();
        }

        public IList<ItemDaDispensa> ObterItensParaComprar()
        {
            return Itens.Where(o => o.QuantidadeParaComprar > 0).ToList();
        }

        public void GuardaItemNaDispensa(Guid produtoId, decimal qtde)
        {
            var item = PesquisarItemPorProdutoId(produtoId) ?? IncluirItem(produtoId);                
            item.GuardarNaDispensa(qtde);
        }

        public void MarcarParaComprar(Guid produtoId, decimal qtdeComprar)
        {
            var item = PesquisarItemPorProdutoId(produtoId) ?? IncluirItem(produtoId);
            item.MarcarParaComprar(qtdeComprar);
        }

        public void UsarItem(Guid produtoId, decimal qtde)
        {
            var item = PesquisarItemPorProdutoId(produtoId);
            item.Usar(qtde);
        }

        private ItemDaDispensa IncluirItem(Guid produtoId)
        {
            var item = new ItemDaDispensa(DispensaId, produtoId, 0m);
            Itens.Add(item);
            return item;
        }

        public ItemDaDispensa PesquisarItemPorProdutoId(Guid produtoId)
        {
            return Itens.FirstOrDefault(o => o.ProdutoId == produtoId);
        }
    }
}
