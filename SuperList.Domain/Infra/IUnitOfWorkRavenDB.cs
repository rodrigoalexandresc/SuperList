using System.Threading.Tasks;

namespace SuperList.Domain.Infra
{
    public interface IUnitOfWorkRavenDB 
    {
        Task Commit();
    }
}
