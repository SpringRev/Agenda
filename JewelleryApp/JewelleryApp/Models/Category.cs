using System;
using System.Collections.Generic;

namespace JewelleryApp.Models
{
    public partial class Category
    {
        public Category()
        {
            Titles = new HashSet<Title>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Title> Titles { get; set; }
    }
}
