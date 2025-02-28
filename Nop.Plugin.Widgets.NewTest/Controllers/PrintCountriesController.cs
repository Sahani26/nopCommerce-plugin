using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nop.Services.Directory;
using Nop.Web.Framework.Controllers;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.NewTest.Controllers
{
    [Route("Admin/PrintCountries")]
    public class PrintCountriesController : BasePluginController
    {
        private readonly ICountryService _countryService;

        public PrintCountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [AllowAnonymous] // Allows access without authentication
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var countries = (await _countryService.GetAllCountriesAsync()).Select(c => c.Name).ToList();
            return View("~/Plugins/Widgets.NewTest/Views/PrintCountries/Index.cshtml", countries);
        }
    }
}
