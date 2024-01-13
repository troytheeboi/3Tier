using System.Linq.Expressions;
using Domain.Entities.Bases;

namespace Domain.Repo_Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task<T> Insert(T item);
    Task<T> Update(T item);
    Task<T> Remove(T item);
        
    Task<ICollection<T>> Get(List<Expression<Func<T, bool>>> filters = null);
    IQueryable<T> GetAsQueryable(List<Expression<Func<T, bool>>> filters = null);
    Task<T?> GetByIdAsync(int id);
    Task<bool> EntityExsist(int Id);
}