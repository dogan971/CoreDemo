using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class About
    {
        [Key]
        public int aboutID { get; set; }
        public string aboutDetails1 { get; set; }
        public string aboutDetails2 { get; set; }
        public string aboutImage1 { get; set; }
        public string aboutImage2 { get; set; }
        public string aboutMapLocation { get; set; }
        public bool aboutStatus { get; set; }
    }
}
