using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public bool categoryStatus { get; set; }

        public List<Blog> Blogs { get; set; }


    }
}
