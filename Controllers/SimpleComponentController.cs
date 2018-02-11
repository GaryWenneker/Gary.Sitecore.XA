
using Newtonsoft.Json.Linq;
using Sitecore.DependencyInjection;
using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Gary.XA.Feature.Media.Controllers
{
    public class SimpleComponentController : Controller
    {


        //public override ActionResult Index()
        //{
        //    ViewBag.Module = "Cito.default.SimpleComponent";//Would it be useful to transfer this information to the rendering?
        //    var item = RenderingContext.Current.Rendering.Item;

        //    var helper = RenderingContext.Current.PageContext.HtmlHelper;

        //    var scHelper = new SitecoreHelper(helper);

        //    JObject o = new JObject(new JProperty("text", "Hello from the SimpleComponentController"), new JProperty("title", "This is from the server"));

        //    return PartialView("Index", o);
        //    //return PartialView("Index", this.GetModel());
        //}

        public ActionResult React()
        {
            ViewBag.Module = "Cito.default.SimpleComponent";//Would it be useful to transfer this information to the rendering?
            var item = RenderingContext.Current.Rendering.Item;

            var helper = RenderingContext.Current.PageContext.HtmlHelper;

            var scHelper = new SitecoreHelper(helper);

            JObject o = new JObject(new JProperty("text", "ReactResult: Hello from the SimpleComponentController"), new JProperty("title", "This is from the server"));

            return PartialView(o);
            //return PartialView("Index", this.GetModel());
        }

    }
}