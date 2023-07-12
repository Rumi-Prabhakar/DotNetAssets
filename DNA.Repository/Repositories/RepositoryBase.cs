using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected DotNetAssetsContext DotNetAssetsContext;

    public RepositoryBase(DotNetAssetsContext context) 
        => DotNetAssetsContext = context;
    public void Create(T Entity) => DotNetAssetsContext.Set<T>().Add(Entity);

    public void Delete(T Entity) => DotNetAssetsContext.Set<T>().Remove(Entity);

    public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges ? 
        DotNetAssetsContext.Set<T>().AsNoTracking()
        : DotNetAssetsContext.Set<T>();


    public async Task<T> FindByCondition(Expression<Func<T, bool>> expression) =>
        
          await DotNetAssetsContext.Set<T>().FirstOrDefaultAsync(expression);

    public void Update(T Entity) => DotNetAssetsContext.Set<T>().Update(Entity);
}
