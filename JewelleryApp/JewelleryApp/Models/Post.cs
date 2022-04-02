using System;
using System.Collections.Generic;

namespace JewelleryApp.Models
{
    public partial class Post
    {
        public Post()
        {
            InverseMasterPost = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string? PostDetail { get; set; }
        public int? MasterPostId { get; set; }
        public int TitleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Post? MasterPost { get; set; }
        public virtual Title Title { get; set; } = null!;
        public virtual ICollection<Post> InverseMasterPost { get; set; }
    }
}
