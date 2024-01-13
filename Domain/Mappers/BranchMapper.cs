using Domain.DTOs;
using Domain.Entities;

namespace Domain.Mappers;

public class BranchMapper
{

    public static BranchEntity MapToEntity(BranchDto dto)
    {
        return new BranchEntity()
        {
            Location = dto.Location,
            capacity = dto.Capacity,
            ManagerID = dto.ManagerId
        };
    }

    // If needed, you can also create a method to update an existing entity
    public static void UpdateEntityFromDto(BranchEntity entity, BranchDto dto)
    {
        entity.Location = dto.Location;
        entity.capacity = dto.Capacity;
        entity.ManagerID = dto.ManagerId;
    }
    
    
}