using Interface.Models.Bases;

namespace Interface.Models
{
    public class SupplierEntity:ParentEntity
    {
        public string supplierName { get; set; }
        public int phoneNumber { get; set; }
        public string supplierAddress { get; set;}

    }
}
