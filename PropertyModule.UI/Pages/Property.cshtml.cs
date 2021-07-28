using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PropertyModule.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyModule.UI.Pages
{
    public class PropertyModel : PageModel
    {
        private readonly ILogger<PropertyModel> _logger;
        private readonly IGenericRepo<PropertyEntity> _propertyRepo;

        public PropertyModel(ILogger<PropertyModel> logger,
             IGenericRepo<PropertyEntity> propertyRepo)
        {
            _logger = logger;
            _propertyRepo = propertyRepo;
        }

        public async Task OnGet()
        {
            _logger.LogInformation("<--- Hit Property Page -->");
            PropertyEntities = await _propertyRepo.GetAll();
        }

        [BindProperty]
        public List<PropertyEntity> PropertyEntities { get; set; }
    }
}
