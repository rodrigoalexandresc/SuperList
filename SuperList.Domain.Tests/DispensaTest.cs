using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperList.Domain.Tests
{
    [TestClass]
    public class DispensaTest
    {   
        public Dispensa Preparar()
        {
            var dispensa = new Dispensa();
            var dispensaId = Guid.NewGuid();
            var usuarioId = Guid.NewGuid();

            dispensa.CriarDispensa(dispensaId, usuarioId);

            return dispensa;
        }
            
        [TestMethod]
        public void GuardaItemNaDispensaTest()
        {
            var dispensa = Preparar();

            var produtoId1 = Guid.NewGuid();
            var produtoId2 = Guid.NewGuid();

            dispensa.GuardaItemNaDispensa(produtoId1, 10m);
            dispensa.GuardaItemNaDispensa(produtoId2, 2.5m);            

            Assert.AreEqual(dispensa.Itens.Count, 2);

            var item1 = dispensa.Itens.First(o => o.ProdutoId == produtoId1);
            var item2 = dispensa.Itens.First(o => o.ProdutoId == produtoId2);

            Assert.AreEqual(item1.Quantidade, 10m);
            Assert.AreEqual(item2.Quantidade, 2.5m);
        }

        [TestMethod]
        public void MarcarItemParaComprarTest()
        {
            var dispensa = Preparar();

            var produtoId1 = Guid.NewGuid();
            var produtoId2 = Guid.NewGuid();

            dispensa.MarcarParaComprar(produtoId1, 10m);
            var item1 = dispensa.Itens.First(o => o.ProdutoId == produtoId1);

            Assert.AreEqual(item1.QuantidadeParaComprar, 10m);
        }

        [TestMethod]
        public void UsarItemTest()
        {
            var dispensa = Preparar();

            var produtoId1 = Guid.NewGuid();
            dispensa.GuardaItemNaDispensa(produtoId1, 15m);
            dispensa.UsarItem(produtoId1, 10m);

            var item1 = dispensa.PesquisarItemPorProdutoId(produtoId1);

            Assert.AreEqual(item1.Quantidade, 5m);
            Assert.AreEqual(item1.QuantidadeParaComprar, 10m);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UsarItemSemSaldoTest()
        {
            var dispensa = Preparar();

            var produtoId1 = Guid.NewGuid();

            dispensa.GuardaItemNaDispensa(produtoId1, 10m);
            dispensa.UsarItem(produtoId1, 15m);
        }

        [TestMethod]
        public void ObterItensParaComprarTest()
        {
            var dispensa = Preparar();

            var produtoId1 = Guid.NewGuid();
            var produtoId2 = Guid.NewGuid();

            dispensa.GuardaItemNaDispensa(produtoId1, 0m);
            dispensa.GuardaItemNaDispensa(produtoId2, 0m);

            dispensa.MarcarParaComprar(produtoId1, 10m);
            dispensa.MarcarParaComprar(produtoId2, 5m);

            var lista = dispensa.ObterItensParaComprar();

            Assert.AreEqual(lista.Count, 2);
            Assert.IsFalse(lista.Any(o => o.QuantidadeParaComprar <= 0));
        }
    }
}
