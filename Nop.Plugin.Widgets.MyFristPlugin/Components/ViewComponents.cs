using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.MyFristPlugin.Components
{
    public class ViewComponents: NopViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        { 
            var model = "this is my first plugin"; 
            return View("~/Plugins/Widgets.MyFristPlugin/Views/PublicInfo.cshtml", model);
        }

    }
}
