using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Authentication.Pages {
    public class ErrorForbidenModel : PageModel {
        public string Message { get; set; }

        public void OnGet () {
            Message = "You need to be admin";
        }
    }
}