using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Interface.Models.Bases;

namespace Interface.Models
{
    public class EmployeeEntity:PersonEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int Salary { get; set; }

        [ForeignKey("BranchEntity")]
        public int BranchId { get; set; } 
        public BranchEntity branch { get; set; }

    }
}
