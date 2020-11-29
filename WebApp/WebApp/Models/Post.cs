using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Post
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public Post()
        {
            Time = DateTime.Now;
        }
    }
}
