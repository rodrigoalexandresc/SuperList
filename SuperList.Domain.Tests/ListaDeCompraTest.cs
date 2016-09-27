using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Domain.Tests
{
    [TestFixture]
    public class ListaDeCompraTest
    {
        private ListaDeCompra CriarListaDeCompra()
        {
            var usuarioId = Guid.NewGuid();
            return new ListaDeCompra(usuarioId);
        }

        [Test]
        public void ListaDeCompra_IncluirItem()
        {
            var lista = CriarListaDeCompra();
            var produtoId = Guid.NewGuid();
            var produto2Id = Guid.NewGuid();

            lista.IncluirItem(produtoId, 1m);
            lista.IncluirItem(produto2Id, 2m);
            lista.IncluirItem(produtoId, 3m);
            var itemProduto1 = lista.Itens.First(o => o.ProdutoId == produtoId);
            var itemProduto2 = lista.Itens.First(o => o.ProdutoId == produto2Id);

            Assert.AreEqual(2m, lista.Itens.Count);
            Assert.AreEqual(4m, itemProduto1.Quantidade);
            Assert.AreEqual(2m, itemProduto2.Quantidade);
        }

        //[TestMethod]
        //public void CriarNovaCompraTest()
        //{
        //    var lista = new ListaDeCompra();

        //    lista.CriarNovaCompra();

        //    Assert.AreEqual(lista.Status, StatusDaListaDeCompraEnum.Aberta);
        //    Assert.IsNotNull(lista.DataCriacao);
        //}

        //[TestMethod]
        //public void IncluirItemTest()
        //{
        //    var lista = new ListaDeCompra();

        //    lista.CriarNovaCompra();

        //    var produtoId1 = Guid.NewGuid();
        //    lista.IncluirItem(produtoId1, 10m);

        //    var produtoId2 = Guid.NewGuid();
        //    lista.IncluirItem(produtoId2, 5m);

        //    Assert.AreEqual(lista.Itens.Count, 2);
        //    var item1 = lista.Itens.FirstOrDefault(o => o.ProdutoId == produtoId1);
        //    Assert.AreEqual(item1.Quantidade, 10m);
        //}

        //[TestMethod]
        //public void MarcarItemComoCompradoTest()
        //{
        //    var lista = new ListaDeCompra();

        //    var produtoId1 = Guid.NewGuid();
        //    var produtoId2 = Guid.NewGuid();

        //    var itens = new List<ItemDaListaDeCompra>
        //    {
        //        new ItemDaListaDeCompra(produtoId1, 1m),
        //        new ItemDaListaDeCompra(produtoId2, 5m)
        //    };

        //    lista.MarcarItemComoComprado(produtoId1);

        //    var item = lista.Itens.FirstOrDefault(o => o.ProdutoId == produtoId1);
        //    Assert.IsTrue(item.Comprado);
        //}
    }
}
