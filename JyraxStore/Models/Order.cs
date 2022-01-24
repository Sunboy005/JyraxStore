using System.Collections.Generic;

namespace JyraxStore.Models
{
    public class Order : BaseEntity
    {
        public List<Product> ProductList { get; set; }
        public decimal? Price { get; set; }

    }
}
