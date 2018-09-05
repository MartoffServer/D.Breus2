using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.Privat.Components
{
    [ViewComponent(Name = "Privat")]
    public class PaymentPrivatViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.Privat/Views/PaymentInfo.cshtml");
        }
    }
}
