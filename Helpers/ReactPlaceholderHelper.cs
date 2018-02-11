using Gary.XA.Feature.Media.Models;
using Gary.XA.Feature.Media.SitecoreExtensions;
using Sitecore.Mvc.Helpers;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Gary.XA.Feature.Media.Helpers
{
    public static class ReactPlaceholderHelper
    {
        public static ReactPlaceholder GetPlaceholder(string placeholderName, HtmlHelper htmlHelper, bool isDynamic)
        {

            var scHelper = new SitecoreHelper(htmlHelper);
            var placeholder = isDynamic ? scHelper.DynamicPlaceholder(placeholderName) : scHelper.Placeholder(placeholderName);

            Regex regex = new Regex(@"key='(.[^']+)'"); ;
            if (!Sitecore.Context.PageMode.IsExperienceEditor) regex = new Regex(@"id=""(.[^""]+)""");
            Match match = regex.Match(placeholder.ToString());
            string key = match.Groups[1].Value;

            //todo: find out if we can get the original placeholder keys via Sitecore.Context.Page.Renderings...

            return new ReactPlaceholder() { PlaceholderKey = key, Placeholder = placeholder.ToString(), IsDynamic = isDynamic };
        }
    }
}