using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PrivateMessage
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public virtual AppUser Sender { get; set; }

        public PrivateMessage()
        {
            Time = DateTime.Now.ToUniversalTime();
        }
    }
}
