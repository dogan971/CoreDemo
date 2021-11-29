using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Blog
    {
        [Key]
        public int blogID { get; set; }
        public string blogContent { get; set; }
        public string blogThumbnailImage { get; set; }
        public string blogImage { get; set; }
        public string blogTitle { get; set; }
        public bool blogStatus { get; set; }
        public DateTime blogCreateDate { get; set; }

        public List<Comment> comments { get; set; }
        public int categoryID { get; set; }
        public Category category { get; set; }

        public Writer writer { get; set; }
        public int writerID { get; set; }
    }
}
