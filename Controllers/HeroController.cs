using Gary.XA.Feature.Media.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using Sitecore.XA.Foundation.RenderingVariants.Controllers;
using Sitecore.XA.Foundation.RenderingVariants.Fields;

namespace Gary.XA.Feature.Media.Controllers
{
    public class HeroController : VariantsController
    {
        public ActionResult React()
        {
            
            var item = RenderingContext.Current.Rendering.Item;
            var helper = RenderingContext.Current.PageContext.HtmlHelper;

            // get variant data from SXA
            var repos = this.VariantsRepository;
            var field = repos.VariantFields.Where(x => x.ItemName.Equals("Controller", System.StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            var controllerField = field as VariantField;
            string moduleName = controllerField?.DataAttributes["ModuleName"];

            ViewBag.Module = moduleName; 


            var placeholders = new List<ReactPlaceholder>() { };


            return PartialView(new DummyViewModel { Title = FieldRenderer.Render(item, "Title"), Text = FieldRenderer.Render(item, "Body"), Placeholders = placeholders });
        }
    }
}
