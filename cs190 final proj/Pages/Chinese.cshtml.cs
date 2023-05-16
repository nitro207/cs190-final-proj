
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cs190_final_proj.Pages
{
	public class ChineseModel : PageModel
    {
        private readonly ILogger<ChineseModel> _logger;

        public ChineseModel(ILogger<ChineseModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
