using Domain.DTOs;
using Domain.Entities;
using Domain.Mappers;
using Domain.Repo_Interfaces;

namespace Business.Services;

public class BranchServices
{
    readonly IBrnachRepository _branchRepository;

    public BranchServices(IBrnachRepository branchRepository)
    {
        _branchRepository = branchRepository;
    }

   /* public async Task AddBranch(string location, int capacity, int? managerId)
    {

        BranchEntity? branchesWithLocation = await _branchRepository.GetByLocation(location);

        if (branchesWithLocation is null) //if a locations doesn't exist
        {
            BranchDto branchDto = new BranchDto(location,capacity,managerId);
            
            _branchRepository.Add(BranchMapper.MapToEntity(branchDto));
        }

        await _branchRepository.SaveChanges();
        
    }

    public async Task<List<BranchEntity?>> GetAll()
    {
        return await _branchRepository.GetAll();
    }*/
}