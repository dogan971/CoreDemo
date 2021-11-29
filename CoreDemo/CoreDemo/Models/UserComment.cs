using System;

namespace CoreDemo.Models
{
    public class UserComment
    {

        public int ID { get; set; }
        public string userName { get; set; }
        public string commentTitle { get; set; }
        public string commentContent { get; set; }
        public DateTime commentDate { get; set; }

    }
}
