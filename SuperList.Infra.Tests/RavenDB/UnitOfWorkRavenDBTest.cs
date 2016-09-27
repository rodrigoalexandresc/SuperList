using NUnit.Framework;
using SuperList.Infra.Repository.RavenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Infra.Tests.RavenDB
{
    [TestFixture]
    public class UnitOfWorkRavenDBTest
    {
        [Test]
        public void IniciarSessaoRavenDB()
        {
            using (var uow = new UnitOfWorkRavenDB())
            {
                Assert.IsNotNull(uow.Session);
            }
        }
    }
}
