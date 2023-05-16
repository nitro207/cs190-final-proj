using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cs190_final_proj.Pages
{
	public class AmericanModel : PageModel
    {
        private readonly ILogger<AmericanModel> _logger;

        public AmericanModel(ILogger<AmericanModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
