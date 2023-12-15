using System.ComponentModel.DataAnnotations;
using Interface.Models.Bases;

namespace Interface.Models
{
    public class PaymentEntity:BaseEntity
    {
        [Required]
        public float Amount { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public string PaymentMethod { get; set; }

    }
}
