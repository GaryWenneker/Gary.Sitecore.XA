using Gary.XA.Feature.Media.Helpers;
using Gary.XA.Feature.Media.Models;
using Newtonsoft.Json.Linq;
using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Gary.XA.Feature.Media.Controllers
{
    public class MainColumn4_4_4Controller : Controller
    {
        public ActionResult React()
        {

            ViewBag.Module = "Cito.default.Main3Column4_4_4";//Would it be useful to transfer this information to the rendering?
            var item = RenderingContext.Current.Rendering.Item;
            var helper = RenderingContext.Current.PageContext.HtmlHelper;



            var placeholder = ReactPlaceholderHelper.GetPlaceholder("main", helper, true);
            var placeholder2 = ReactPlaceholderHelper.GetPlaceholder("main2", helper, true);
            var placeholder3 = ReactPlaceholderHelper.GetPlaceholder("main3", helper, true);

            var placeholders = new List<ReactPlaceholder>() { placeholder, placeholder2, placeholder3 };


            return PartialView(new DummyViewModel { Title = FieldRenderer.Render(item, "Title"), Text = FieldRenderer.Render(item, "Body"), Placeholders = placeholders });
        }
    }
}