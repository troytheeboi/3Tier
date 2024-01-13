using Domain.Entities.Bases;

namespace Domain.Entities;

public class SupplierEntity:BaseEntity
{
    public string supplierName { get; set; }
    public int phoneNumber { get; set; }
    public string supplierAddress { get; set;}

}