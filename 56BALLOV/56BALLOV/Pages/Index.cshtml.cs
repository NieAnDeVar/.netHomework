using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _56BALLOV.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string url { get; set; }
        [BindProperty]
        public string Config { get; set; }
        [BindProperty]
        public string Parametr { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //models.ResultM.ParseSyte(url, int.Parse(Parametr), int.Parse(Config), true);
            HttpContext.Response.Cookies.Append("Url", url);
            HttpContext.Response.Cookies.Append("Config", Config);
            HttpContext.Response.Cookies.Append("Param", Parametr);
            return  Redirect("/Result");
        }
    }
}
