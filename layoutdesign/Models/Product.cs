using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace layoutdesign.Models
{
    public class Product : BaseEntity
    {

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Title { get; set; }

        [Required]

        public string slug { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        [Range(0.01, 100000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }


        public string Description { get; set; }

        [Required]
        public Int64 CategoryId { get; set; }

        public Category Category { get; set; }

        public Int64 BrandId { get; set; }
        public Brand Brand { get; set; }

        public string ModelNumder { get; set; }

        public string created_by { get; set; }

        public Appuser Appuser { get; set; }


    }
}
