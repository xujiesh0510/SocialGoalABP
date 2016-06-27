using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SocialGoal.EntityFramework.Repositories
{
    public abstract class SocialGoalRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SocialGoalDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SocialGoalRepositoryBase(IDbContextProvider<SocialGoalDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SocialGoalRepositoryBase<TEntity> : SocialGoalRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SocialGoalRepositoryBase(IDbContextProvider<SocialGoalDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
