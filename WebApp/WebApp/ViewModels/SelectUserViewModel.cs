using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class SelectUserViewModel
    {
        public IEnumerable<SelectListItem> Users { get; set; }

        public string secondUserId { get; set; }
    }
}
