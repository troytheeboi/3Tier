using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Interface.Models.Bases;

namespace Interface.Models
{
    public class ShoppingCartEntity:ParentEntity
    {
        [Required]
        public DateTime DateCreated { get; set; }

        [ForeignKey("CustomerEntity")]
        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }

        public List<ProductEntity> products { get; set; }

    }
}
