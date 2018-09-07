using EasyLOB.Data;
using EasyLOB.Persistence;

namespace MyLOB.Persistence
{
    public interface IMyLOBGenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IZDataBase
    {
    }
}
