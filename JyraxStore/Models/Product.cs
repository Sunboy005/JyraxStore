using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JyraxStore.Models
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal? Price { get; set; }

        public List<ProductImage> Images { get; set; }

        [Required]
        public string PostedBy { get; set; }
        public AppUser AppUser { get; set; }

    }
}
