using NUnit.Framework;
using SuperList.Domain;
using SuperList.Infra.Repository.RavenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Infra.Tests.RavenDB
{
    [TestFixture]
    public class ListaDeCompraRepositoryTest
    {
        private ListaDeCompraRepository CreateRepository()
        {
            return new ListaDeCompraRepository(new UnitOfWorkRavenDB());
        }

        private ListaDeCompra CreateListaDeCompra()
        {
            var id = Guid.NewGuid();
            var usuarioId = Guid.NewGuid();
            var listaDeCompra = new ListaDeCompra(usuarioId);
            return listaDeCompra;
        }

        [Test]
        public void ListaDeCompraRepositorySaveAsync()
        {

        }

        [Test]
        public void ListaDeCompraRepositoryCRUD()
        {
            var repository = CreateRepository();
            var entity = CreateListaDeCompra();
            var task = repository.SaveAsync(entity);
            task.Wait();

            var taskEntityStored = repository.FindAsync(entity.Id);
            taskEntityStored.Wait();

            Assert.AreEqual(entity.DataCriacao, taskEntityStored.Result.DataCriacao);
        }

        [Test]
        public void ListaDeCompraRepositoryObterListasDoUsuario()
        {
            var repository = CreateRepository();
            var entity = CreateListaDeCompra();
            var task = repository.SaveAsync(entity);
            task.Wait();

            var taskLista = repository.ObterListasDoUsuario(entity.UsuarioId);
            taskLista.Wait();

            Assert.AreEqual(entity.Id, taskLista.Result.First().Id);
        }
    }
}
