using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace santwel.poc.EntityFramework.Repositories
{
    public abstract class pocRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<pocDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected pocRepositoryBase(IDbContextProvider<pocDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class pocRepositoryBase<TEntity> : pocRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected pocRepositoryBase(IDbContextProvider<pocDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
