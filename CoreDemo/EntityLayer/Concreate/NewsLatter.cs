using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class NewsLatter
    {
        [Key]
        public int mailID { get; set; }

        public string mail { get; set; }
        public bool mailStatus { get; set; }

    }
}
