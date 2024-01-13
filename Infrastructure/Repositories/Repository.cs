using System.Linq.Expressions;
using Domain.Entities.Bases;
using Domain.Enum;
using Domain.Repo_Interfaces;
using Infrastructure.DB_Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;


public class Repository<T> : IRepository<T> where T : BaseEntity
{
    MyDbContext _context;
    private readonly ILogger<IRepository<T>> _logger;

    public Repository(MyDbContext context, ILogger<IRepository<T>> logger)
    {
        _context = context;
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<ICollection<T>> Get(List<Expression<Func<T, bool>>> filters = null)
    {
        var _table = _context.Set<T>();
        var query = _table.AsQueryable();
        if (filters != null)
        {
            foreach (var filter in filters)
            {
                query = query.Where(filter);
            }
        }

        return await query.AsNoTracking().ToListAsync();
    }


    public IQueryable<T> GetAsQueryable(List<Expression<Func<T, bool>>> filters = null)
    {
        var _table = _context.Set<T>();
        var query = _table.AsQueryable();
        if (filters != null)
        {
            foreach (var filter in filters)
            {
                query = query.Where(filter);
            }
        }

        return query.AsNoTracking().AsQueryable();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        var _table = _context.Set<T>();
        var query = await _table.FirstOrDefaultAsync(t => t.Id == id);
        return query;
    }

    public async Task<bool> EntityExsist(int Id)
    {
        var _table = _context.Set<T>();
        var query = await _table.AnyAsync(e => e.Id == Id);
        return query;
    }

    public async Task<T> Insert(T item)
    {
        var _table = _context.Set<T>();
        item.LastModified = DateTime.Now;
        item.CreatedAt = DateTime.Now;
        await _table.AddAsync(item);
        await _context.SaveChangesAsync();
        return item;
    }

    public async Task<T> Update(T item)
    {
        var _table = _context.Set<T>();
        item.LastModified = DateTime.Now;
        _table.Update(item);
        await _context.SaveChangesAsync();
        return item;
    }

    public async Task<T> Remove(T item)
    {
        var _table = _context.Set<T>();
        item.LastModified = DateTime.Now;
        item.Status = ItemStatus.NotActive;
        _table.Update(item);
        await _context.SaveChangesAsync();
        return item;
    }
}


       
 
