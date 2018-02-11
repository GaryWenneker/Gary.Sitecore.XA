using Newtonsoft.Json.Linq;
using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Gary.XA.Feature.Media.Controllers
{
    public class CollapsibleListController : Controller
    {
        // GET: CollapsibleList
        public ActionResult React()
        {
            ViewBag.Module = "Cito.default.CollapsibleList";//Would it be useful to transfer this information to the rendering?
            var item = RenderingContext.Current.Rendering.Item;

            var helper = RenderingContext.Current.PageContext.HtmlHelper;

            var scHelper = new SitecoreHelper(helper);

            JArray array = new JArray(
                new JObject(new JProperty("text", "Missie"), new JProperty("url", "http://youtube.com"), new JProperty("target", "_blank")),
                new JObject(new JProperty("text", "Bedrijfsinformatie"), new JProperty("url", "http://facebook.com"), new JProperty("target", "_blank")),
                new JObject(new JProperty("text", "Werken bij"), new JProperty("url", "http://twitter.com"), new JProperty("target", "_blank")),
                new JObject(new JProperty("text", "Sponsoring"), new JProperty("url", "http://linkedin.com"), new JProperty("target", "_blank")),
                new JObject(new JProperty("text", "Pers"), new JProperty("url", "http://linkedin.com"), new JProperty("target", "_blank"))
                );



            return PartialView(new JObject(new JProperty("title", "Gary SXA Collapsible Link") ,new JProperty("links", array)));
        }
    }
}