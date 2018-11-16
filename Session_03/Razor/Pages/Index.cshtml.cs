using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Pages {
    public class IndexModel : PageModel {
        public string Message { get; private set; } = "Hello!";
        public void OnGet () {
            Message += $" Server time is {DateTime.Now}";
        }
    }
}