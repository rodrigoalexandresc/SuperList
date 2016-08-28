using System;

namespace SuperList.Domain
{
    public class ItemDaDispensa
    {
        public ItemDaDispensa(Guid dispensaId, Guid produtoId, decimal qtdeInicial = 0m)
        {
            DispensaId = dispensaId;
            ProdutoId = produtoId;
            Quantidade = qtdeInicial;
        }

        public Guid DispensaId { get; private set; }

        public Guid ProdutoId { get; private set; }

        public decimal Quantidade { get; private set; }

        public decimal QuantidadeParaComprar { get; private set; }

        public void MarcarParaComprar(decimal qtde)
        {
            QuantidadeParaComprar = qtde;
        }

        public void GuardarNaDispensa(decimal qtde)
        {
            Quantidade += qtde;

            QuantidadeParaComprar -= qtde;
            if (QuantidadeParaComprar < 0)
                QuantidadeParaComprar = 0;
        }

        public void Usar(decimal qtde)
        {
            if (qtde > Quantidade)
                throw new Exception("Saldo na dispensa insuficiente");

            Quantidade -= qtde;
            QuantidadeParaComprar += qtde;
        }
    }
}