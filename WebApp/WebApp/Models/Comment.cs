using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public virtual Post Post { get; set; }
        public int PostId { get; set; }
        public string UserName { get; set; }

        public Comment()
        {
            Time = DateTime.Now.ToUniversalTime();
        }
    }
}
