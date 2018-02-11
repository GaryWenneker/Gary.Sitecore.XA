using Gary.XA.Feature.Media.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Sitecore.XA.Foundation.RenderingVariants.Controllers;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Gary.XA.Feature.Media.Controllers
{
    public class HeroVideoController : VariantsController
    {
        public ActionResult React()
        {

            
            var item = RenderingContext.Current.Rendering.Item;
            var helper = RenderingContext.Current.PageContext.HtmlHelper;

            var val = item?.Fields["ModuleName"]?.Value;

            ViewBag.Module = "Cito.default.HeroVideo";//Would it be useful to transfer this information to the rendering?


            var placeholders = new List<ReactPlaceholder>() { };


            return PartialView(new DummyViewModel { Title = FieldRenderer.Render(item, "Title"), Text = FieldRenderer.Render(item, "Body"), Placeholders = placeholders });
        }
    }
}