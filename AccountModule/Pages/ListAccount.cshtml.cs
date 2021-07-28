using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AccountModule.Pages
{
    public class ListAccountModel : PageModel
    {
        private readonly ILogger<ListAccountModel> _logger;

        public ListAccountModel(ILogger<ListAccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
