using SuperList.Domain;
using SuperList.Domain.Infra;
using SuperList.Domain.Repositories;
using System.Threading.Tasks;

namespace SuperList.Infra.Repository.RavenDB
{
    public class SecaoRepository : RavenDBRepository<Secao>, ISecaoRepository
    {
        public SecaoRepository(IUnitOfWorkRavenDB uow) : base(uow)
        {           
        }
    }   
}
