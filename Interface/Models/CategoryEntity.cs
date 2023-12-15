using System.ComponentModel.DataAnnotations;
using Interface.Models.Bases;

namespace Interface.Models
{
    public class CategoryEntity:ParentEntity
    {
        [Required]
        public string CatName { get; set; }
        [Required]
        public string CatDescription { get; set; }

        public virtual List<ProductEntity> Products { get; set; }

    }
}
