using System.ComponentModel.DataAnnotations;

namespace layoutdesign.Models
{
    public class Cart : BaseEntity
    {
        [Required]
        public string UserId { get; set; } // Assuming a user is linked to the cart

        public Appuser User { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

    }
}
