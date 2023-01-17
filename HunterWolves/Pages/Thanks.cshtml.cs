using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HunterWolves.Pages
{
    public class ThanksModel : PageModel
    {
        private readonly ILogger<ThanksModel> _logger;

        public ThanksModel(ILogger<ThanksModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}