using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GameShop.Shared
{
    public class ProductVariant
    {
        // JsonIgnore for at ungå endless loop "Circular reference".
        [JsonIgnore]
        public Product Product { get; set; }

        public Guid ProductId { get; set; }
        
        public ProductType ProductType { get; set; }

        public Guid ProductTypeId { get; set; }

        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
    }
}
