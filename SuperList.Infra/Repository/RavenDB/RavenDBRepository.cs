using Raven.Client;
using SuperList.Domain.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Infra.Repository.RavenDB
{
    public abstract class RavenDBRepository
    {
        IAsyncDocumentSession session;
        UnitOfWorkRavenDB unitOfWork;

        public RavenDBRepository(IUnitOfWorkRavenDB unitOfWork)
        {
            this.unitOfWork = (UnitOfWorkRavenDB)unitOfWork;
            session = this.unitOfWork.Session;
        }
    }
}
