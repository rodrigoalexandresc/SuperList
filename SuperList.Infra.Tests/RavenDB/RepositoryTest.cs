using NUnit.Framework;
using SuperList.Domain.Infra;
using SuperList.Infra.Repository.RavenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperList.Infra.Tests.RavenDB
{
    public abstract class RepositoryTest<TEntity, TRepository> where TRepository : RavenDBRepository<TEntity>, new()
    {
        public abstract TRepository CreateRepository();

        public abstract TEntity CreateEntity();

        //[Test]
        //public void RepositoryCRUDTest()
        //{
        //    var repository = CreateRepository();
        //    var entity = CreateEntity();
        //    var task = repository.SaveAsync(entity);
        //    task.Wait();

        //    var taskEntityStored = repository.FindAsync(entity.Id);
        //    taskEntityStored.Wait();

        //    Assert.AreEqual(entity.DataCriacao, taskEntityStored.Result.DataCriacao);
        //}
    }
}
