﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
            Posts = new HashSet<Post>();
            PrivateMessages = new HashSet<PrivateMessage>();
        }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<PrivateMessage> PrivateMessages { get; set; }
    }
}
