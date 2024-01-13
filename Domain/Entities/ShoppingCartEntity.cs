using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Bases;

namespace Domain.Entities;

public class ShoppingCartEntity:BaseEntity
{
    [Required]
    public DateTime DateCreated { get; set; }

    [ForeignKey("CustomerEntity")]
    public int CustomerId { get; set; }
    public CustomerEntity Customer { get; set; }

    public List<ProductEntity> products { get; set; }

}