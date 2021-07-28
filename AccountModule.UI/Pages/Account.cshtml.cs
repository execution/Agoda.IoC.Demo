using AccountModule.Core.Entities;
using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountModule.UI.Pages
{
    public class AccountModel : PageModel
    {
        private readonly ILogger<AccountModel> _logger;
        private readonly IGenericRepo<AccountEntity> _accountRepo;

        public AccountModel(ILogger<AccountModel> logger,
            IGenericRepo<AccountEntity> accountRepo)
        {
            _logger = logger;
            _accountRepo = accountRepo;
        }

        public async Task OnGet()
        {
            _logger.LogInformation("<--- Hit Account Page -->");
            AccountEntities = await _accountRepo.GetAll();
        }

        [BindProperty]
        public List<AccountEntity> AccountEntities { get; set; }
    }
}
