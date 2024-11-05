using System.ComponentModel.DataAnnotations;

namespace layoutdesign.Models
{
    public class CartItem : BaseEntity
    {
        [Required]
        public Int64 ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public Product Product { get; set; }
        [Required]
        public Int64 CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
