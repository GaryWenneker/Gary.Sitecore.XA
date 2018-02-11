using Gary.XA.Feature.Media.Helpers;
using Gary.XA.Feature.Media.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Gary.XA.Feature.Media.Controllers
{
    public class Main6Column2_2_2_2_2_2Controller : Controller
    {
        public ActionResult React()
        {

            ViewBag.Module = "Cito.default.Main6Column2_2_2_2_2_2";//Would it be useful to transfer this information to the rendering?
            var item = RenderingContext.Current.Rendering.Item;
            var helper = RenderingContext.Current.PageContext.HtmlHelper;



            var placeholder = ReactPlaceholderHelper.GetPlaceholder("main", helper, true);
            var placeholder2 = ReactPlaceholderHelper.GetPlaceholder("main2", helper, true);
            var placeholder3 = ReactPlaceholderHelper.GetPlaceholder("main3", helper, true);
            var placeholder4 = ReactPlaceholderHelper.GetPlaceholder("main4", helper, true);
            var placeholder5 = ReactPlaceholderHelper.GetPlaceholder("main5", helper, true);
            var placeholder6 = ReactPlaceholderHelper.GetPlaceholder("main6", helper, true);

            var placeholders = new List<ReactPlaceholder>() { placeholder, placeholder2, placeholder3, placeholder4, placeholder5, placeholder6 };


            return PartialView(new DummyViewModel { Title = FieldRenderer.Render(item, "Title"), Text = FieldRenderer.Render(item, "Body"), Placeholders = placeholders });
        }
    }
}
