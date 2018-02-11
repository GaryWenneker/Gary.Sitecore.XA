using Gary.XA.Feature.Media.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Gary.XA.Feature.Media.Controllers
{
    public class FooterController : Controller
    {
        public ActionResult React()
        {

            ViewBag.Module = "Cito.default.GaryFooter";//Would it be useful to transfer this information to the rendering?
            var item = RenderingContext.Current.Rendering.Item;
            var helper = RenderingContext.Current.PageContext.HtmlHelper;



            var placeholders = new List<ReactPlaceholder>() { };


            return PartialView(new DummyViewModel { Title = FieldRenderer.Render(item, "Title"), Text = FieldRenderer.Render(item, "Body"), Placeholders = placeholders });
        }
    }
}