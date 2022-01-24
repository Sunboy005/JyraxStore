namespace JyraxStore.Models
{
    public class ProductImage : BaseEntity
    {
        public bool IsMain { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }


        public string ProductId { get; set; }
        public Product Products { get; set; }
    }
}
