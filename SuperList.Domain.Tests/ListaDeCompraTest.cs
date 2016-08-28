using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Domain.Tests
{
    [TestClass]
    public class ListaDeCompraTest
    {
        [TestMethod]
        public void CriarNovaCompraTest()
        {
            var lista = new ListaDeCompra();

            lista.CriarNovaCompra();

            Assert.AreEqual(lista.Status, StatusDaListaDeCompraEnum.Aberta);
            Assert.IsNotNull(lista.DataCriacao);
        }

        [TestMethod]
        public void IncluirItemTest()
        {
            var lista = new ListaDeCompra();

            lista.CriarNovaCompra();

            var produtoId1 = Guid.NewGuid();
            lista.IncluirItem(produtoId1, 10m);

            var produtoId2 = Guid.NewGuid();
            lista.IncluirItem(produtoId2, 5m);

            Assert.AreEqual(lista.Itens.Count, 2);
            var item1 = lista.Itens.FirstOrDefault(o => o.ProdutoId == produtoId1);
            Assert.AreEqual(item1.Quantidade, 10m);
        }

        [TestMethod]
        public void MarcarItemComoCompradoTest()
        {
            var lista = new ListaDeCompra();

            var produtoId1 = Guid.NewGuid();
            var produtoId2 = Guid.NewGuid();

            var itens = new List<ItemDaListaDeCompra>
            {
                new ItemDaListaDeCompra(produtoId1, 1m),
                new ItemDaListaDeCompra(produtoId2, 5m)
            };

            lista.MarcarItemComoComprado(produtoId1);

            var item = lista.Itens.FirstOrDefault(o => o.ProdutoId == produtoId1);
            Assert.IsTrue(item.Comprado);
        }

        //[TestMethod]
        //public void AdicionarQuantidadeCompradaTest()
        //{
        //    var lista = new ListaDeCompra();

        //    var produtoId1 = Guid.NewGuid();
        //    var produtoId2 = Guid.NewGuid();

        //    var itens = new List<ItemDaListaDeCompra>
        //    {
        //        new ItemDaListaDeCompra(produtoId1, 1m),
        //        new ItemDaListaDeCompra(produtoId2, 5m)
        //    };

        //    lista.AdicionarQuantidadeComprada(produtoId1, 1m);


        //}

        //[TestMethod]
        //public void RemoverQuantidadeCompradaTest()
        //{
        //    var lista = new ListaDeCompra();

        //    var produtoId1 = Guid.NewGuid();
        //    var produtoId2 = Guid.NewGuid();

        //    var itens = new List<ItemDaListaDeCompra>
        //    {
        //        new ItemDaListaDeCompra(produtoId1, 1m),
        //        new ItemDaListaDeCompra(produtoId2, 5m)
        //    };
        //}
    }
}
