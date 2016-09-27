using System;
using System.Threading.Tasks;

namespace SuperList.Domain.Infra
{
    public interface IUnitOfWorkRavenDB : IDisposable
    {
        Task Commit();
    }
}
