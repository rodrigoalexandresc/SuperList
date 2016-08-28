using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Client;
using SuperList.Infra.Repository.RavenDB;

namespace SuperList.Infra.Tests.RavenDB
{
    [TestClass]
    public class DataDocumentStoreTest
    {
        [TestMethod]
        public void DocumentStoreInitialize()
        {
            DataDocumentStore.Initialize();

            Assert.IsInstanceOfType(DataDocumentStore.Instance, typeof(IDocumentStore));
        }
    }
}
