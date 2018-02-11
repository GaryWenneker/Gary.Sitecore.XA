using Newtonsoft.Json.Linq;
using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Gary.XA.Feature.Media.Controllers
{
    public class LinkListController : Controller
    {
        //public override ActionResult Index()
        //{
        //    ViewBag.Module = "Cito.default.SocialLinks";//Would it be useful to transfer this information to the rendering?
        //    var item = RenderingContext.Current.Rendering.Item;

        //    var helper = RenderingContext.Current.PageContext.HtmlHelper;

        //    var scHelper = new SitecoreHelper(helper);

        //    JArray array = new JArray(
        //        new JObject(new JProperty("text", "Youtube"), new JProperty("url", "http://youtube.com"), new JProperty("target", "_blank")),
        //        new JObject(new JProperty("text", "Facebook"), new JProperty("url", "http://facebook.com"), new JProperty("target", "_blank")),
        //        new JObject(new JProperty("text", "Twitter"), new JProperty("url", "http://twitter.com"), new JProperty("target", "_blank")),
        //        new JObject(new JProperty("text", "LinkedIn"), new JProperty("url", "http://linkedin.com"), new JProperty("target", "_blank"))
        //        );

 

        //    return PartialView("Index", array);

        //}

        public ActionResult React()
        {
            ViewBag.Module = "Cito.default.SocialLinks";//Would it be useful to transfer this information to the rendering?
            var item = RenderingContext.Current.Rendering.Item;

            var helper = RenderingContext.Current.PageContext.HtmlHelper;

            var scHelper = new SitecoreHelper(helper);

            JArray array = new JArray(
                new JObject(new JProperty("text", "Youtube"), new JProperty("url", "http://youtube.com"), new JProperty("target", "_blank")),
                new JObject(new JProperty("text", "Facebook"), new JProperty("url", "http://facebook.com"), new JProperty("target", "_blank")),
                new JObject(new JProperty("text", "Twitter"), new JProperty("url", "http://twitter.com"), new JProperty("target", "_blank")),
                new JObject(new JProperty("text", "LinkedIn"), new JProperty("url", "http://linkedin.com"), new JProperty("target", "_blank"))
                );



            return PartialView(new JObject(new JProperty("links", array)));

        }
    }
}