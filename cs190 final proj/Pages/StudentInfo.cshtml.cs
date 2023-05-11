using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cs190_final_proj.Pages
{
    public class StudentInfoModel : PageModel
    {
        private readonly ILogger<StudentInfoModel> _logger;

        public StudentInfoModel(ILogger<StudentInfoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}