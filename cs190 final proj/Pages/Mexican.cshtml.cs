
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cs190_final_proj.Pages
{
	public class MexicanModel : PageModel
    {
        private readonly ILogger<MexicanModel> _logger;

        public MexicanModel(ILogger<MexicanModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
