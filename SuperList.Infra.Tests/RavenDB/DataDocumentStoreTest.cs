using NUnit.Framework;
using Raven.Client;
using SuperList.Infra.Repository.RavenDB;

namespace SuperList.Infra.Tests.RavenDB
{
    [TestFixture]
    public class DataDocumentStoreTest
    {
        [Test]
        public void DocumentStoreInitialize()
        {
            DataDocumentStore.Initialize();
            Assert.IsNotNull(DataDocumentStore.Instance);
        }
    }
}
