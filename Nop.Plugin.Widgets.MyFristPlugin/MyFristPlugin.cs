using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.MyFristPlugin
{
    public class MyFristPlugin:BasePlugin,IWidgetPlugin
    {
        public bool HideInWidgetList =>false;

        public Type GetWidgetViewComponent(string widgetZone)
        {
            return typeof(Components.ViewComponents);
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { PublicWidgetZones.HeaderAfter });
        }

        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }
        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
    }
}
