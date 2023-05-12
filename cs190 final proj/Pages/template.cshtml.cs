using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cs190_final_proj.Pages
{
    public class TemplateModel : PageModel
    {
        private readonly ILogger<TemplateModel> _logger;

        public TemplateModel(ILogger<TemplateModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}