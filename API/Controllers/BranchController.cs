using Business.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BranchController:ControllerBase
{
    private readonly BranchServices _branchService;

    public BranchController(BranchServices branchService)
    {
        _branchService = branchService;
    }

    /*[HttpGet(Name = "Branches")]
    public Task<List<BranchEntity?>> Get()
    {
        return _branchService.GetAll();
    }

    [HttpPost(Name = "AddBranch")]
    public Task AddBranch(BranchEntity entity)
    {
        return _branchService.AddBranch(entity.Location, entity.capacity, entity.ManagerID);
    }*/
    
    
}