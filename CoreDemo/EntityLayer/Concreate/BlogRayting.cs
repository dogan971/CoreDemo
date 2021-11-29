using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class BlogRayting
    {
        [Key]
        public int BlogRaytingID { get; set; }
        public int BlogID { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRaytingCount { get; set; }

        public int BlogAverageScore { get; set; }

    }
}
