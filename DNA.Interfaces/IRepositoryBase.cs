using System;
using System.Linq;
using System.Linq.Expressions;

public interface IRepositoryBase<T>
{
	IQueryable<T> FindAll(bool trackChanges);
    Task<T> FindByCondition(Expression <Func<T, bool>> expression);
	void Create(T Entity);
	void Update(T Entity);
	void Delete(T Entity);
}
