using System;
using System.Collections.Generic;

namespace JewelleryApp.Models
{
    public partial class Title
    {
        public Title()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Post> Posts { get; set; }
    }
}
