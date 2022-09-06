using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyASPDemos.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string AuthorName { get; private set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            AuthorName="Rachit Garg";
        }

        public void OnGet()
        {

        }
    }
}
