using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cs190_final_proj.Pages
{
	public class ItalianModel : PageModel
    {
        private readonly ILogger<ItalianModel> _logger;

        public ItalianModel(ILogger<ItalianModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
