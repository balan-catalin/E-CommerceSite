using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
//using Microsoft.Build.Framework;

namespace Core.Entities
{
    public class Product : EntityBase
    {
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required, MaxLength(256)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
    }
}
