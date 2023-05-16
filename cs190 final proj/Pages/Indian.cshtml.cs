
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cs190_final_proj.Pages
{
	public class IndianModel : PageModel
    {
        private readonly ILogger<IndianModel> _logger;

        public IndianModel(ILogger<IndianModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
