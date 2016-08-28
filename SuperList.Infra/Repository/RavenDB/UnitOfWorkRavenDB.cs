using Raven.Client;
using SuperList.Domain.Infra;
using System.Threading.Tasks;

namespace SuperList.Infra.Repository.RavenDB
{
    public class UnitOfWorkRavenDB : IUnitOfWorkRavenDB
    {
        public IAsyncDocumentSession Session { get; private set; }

        public UnitOfWorkRavenDB()
        {
            DataDocumentStore.Initialize();
            Session = DataDocumentStore.Instance.OpenAsyncSession();
        }

        public async Task Commit()
        {
            await Session.SaveChangesAsync();
        }

        public void Dispose()
        {
            Session?.Dispose();
            DataDocumentStore.Instance.Dispose();
        }
    }
}
