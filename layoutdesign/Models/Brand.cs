using System.ComponentModel.DataAnnotations;

namespace layoutdesign.Models
{
    public class Brand : BaseEntity
    {
       
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(00)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
