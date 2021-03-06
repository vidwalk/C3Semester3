﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Authentication.Pages {
    [Authorize (Policy = "MustBeAdmin")]
    public class AboutModel : PageModel {
        public string Message { get; set; }

        public void OnGet () {
            Message = "Your application description page.";
        }
    }
}