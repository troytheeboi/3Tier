using Interface.Models.Bases;

namespace Interface.Models
{
    public class CustomerEntity:PersonEntity
    {
        public int Phone { get; set; }

        public List<ReviewEntity> reviews { get; set; }

        public ShoppingCartEntity cart { get; set; }

        public List<OrderEntity> orders { get; set; }
        
    }
}
