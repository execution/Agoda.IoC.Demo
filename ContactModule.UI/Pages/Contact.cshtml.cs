using Common;
using ContactModule.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactModule.UI.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private readonly IGenericRepo<ContactEntity> _contactRepo;

        public ContactModel(ILogger<ContactModel> logger,
             IGenericRepo<ContactEntity> contactRepo)
        {
            _logger = logger;
            _contactRepo = contactRepo;
        }      

        public async Task OnGet()
        {
            _logger.LogInformation("<--- Hit Contact Page -->");
            ContactEntities = await _contactRepo.GetAll();
        }

        [BindProperty]
        public List<ContactEntity> ContactEntities { get; set; }
    }
}
