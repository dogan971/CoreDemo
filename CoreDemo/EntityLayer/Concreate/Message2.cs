using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Message2
    {
        [Key]
        public int MessageId { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverId { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDateTime { get; set; }
        public bool MessageStatus { get; set; }
        public Writer Sender { get; set; }
        public Writer Receiver { get; set; }
    }
}
