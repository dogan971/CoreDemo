using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Writer
    {
        [Key]
        public int writerID { get; set; }
        public string writerName { get; set; }
        public string writerAbout { get; set; }
        public string writerImage { get; set; }
        public string writerMail { get; set; }
        public int writerPassword { get; set; }
        public bool writerStatus { get; set; }
        public ICollection<Message2> WriterSender { get; set; }

        public object Select()
        {
            throw new NotImplementedException();
        }

        public ICollection<Message2> WriterReceiver { get; set; }

        public List<Blog> Bloglar { get; set; }


    }
}
