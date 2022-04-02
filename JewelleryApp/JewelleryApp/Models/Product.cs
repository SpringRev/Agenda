using System;
using System.Collections.Generic;

namespace JewelleryApp.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public byte[]? Image { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? Details { get; set; }
    }
}
