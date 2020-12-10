using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ProductBrand : EntityBase
    {
        [Required, MaxLength(30)]
        public string Name { get; set; }
    }
}