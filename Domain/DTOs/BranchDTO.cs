namespace Domain.DTOs;

public class BranchDto
{
    public string Location { get; set; }
    public int Capacity { get; set; }
    public int? ManagerId { get; set; }

    public BranchDto(string location, int capacity, int? managerId)
    {
        Location = location;
        Capacity = capacity;
        ManagerId = managerId;
    }
}