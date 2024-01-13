using System.Linq.Expressions;
using Domain.Entities;
using Domain.Repo_Interfaces;
using Infrastructure.DB_Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BranchRepository: IRepository<BranchEntity> ,IBrnachRepository
{
    private readonly MyDbContext _context;

    public BranchRepository(MyDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Task<BranchEntity> Insert(BranchEntity item)
    {
        throw new NotImplementedException();
    }

    public Task<BranchEntity> Update(BranchEntity item)
    {
        throw new NotImplementedException();
    }

    public Task<BranchEntity> Remove(BranchEntity item)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<BranchEntity>> Get(List<Expression<Func<BranchEntity, bool>>> filters = null)
    {
        throw new NotImplementedException();
    }

    public IQueryable<BranchEntity> GetAsQueryable(List<Expression<Func<BranchEntity, bool>>> filters = null)
    {
        throw new NotImplementedException();
    }

    public Task<BranchEntity?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EntityExsist(int Id)
    {
        throw new NotImplementedException();
    }
}