using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Comment
    {
        [Key]
        public int commentID { get; set; }
        public string commentUserName { get; set; }
        public string commentTitle { get; set; }
        public int BlogScore { get; set; }

        public string commentContent { get; set; }
        public DateTime commentDate { get; set; }
        public bool commentStatus { get; set; }

        public int blogID { get; set; }

        public Blog Blog { get; set; }


    }
}
