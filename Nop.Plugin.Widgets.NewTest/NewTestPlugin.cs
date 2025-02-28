using Microsoft.AspNetCore.Routing;
using Nop.Services.Directory;
using Nop.Services.Plugins;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.NewTest
{
    public class NewTestPlugin:BasePlugin, IAdminMenuPlugin
    {
        private readonly ICountryService _countryService;

        public NewTestPlugin(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public override string GetConfigurationPageUrl()
        {
            return "/Admin/PrintCountries/Index";
        }

        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }

        public async Task ManageSiteMapAsync(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "PrintCountries",
                Title = "Print Countries",
                ControllerName = "PrintCountries",
                ActionName = "Index",
                Visible = true,
                RouteValues = new RouteValueDictionary { { "area", "Admin" } }, // Fixed
            };

            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Miscellaneous");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }




        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
    }
}
