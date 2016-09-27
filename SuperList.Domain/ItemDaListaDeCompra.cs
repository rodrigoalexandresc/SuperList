using System;

namespace SuperList.Domain
{
    public class ItemDaListaDeCompra
    {
        public Guid ListaDeCompraId { get; private set; }

        public Guid ProdutoId { get; private set; }

        public decimal Quantidade { get; private set; }

        public decimal Preco { get; private set; }

        public bool Comprado { get; private set; }

        public ItemDaListaDeCompra(Guid produtoId, decimal quantidade)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            Preco = 0m;
        }

        public decimal ValorDoItem
        {
            get
            {
                return Math.Round(Quantidade * Preco, 2);
            }
        }

        public decimal ValorPago
        {
            get
            {
                return Math.Round(Quantidade * Preco, 2);
            }
        }

        public void AdicionarQuantidade(decimal qtde)
        {
            Quantidade += qtde;
        }

    }
}