using System.Web;
//using DynamicPlaceholders.Mvc.Extensions;
using Sitecore;
using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;


namespace Gary.XA.Feature.Media.SitecoreExtensions
{
    public static class HtmlHelperExtensions
    {
        public static HtmlString DynamicPlaceholder(this SitecoreHelper helper, string placeholderName)
        {
            return helper.DynamicPlaceholder(placeholderName, false);
        }

        public static HtmlString DynamicPlaceholder(this SitecoreHelper helper, string placeholderName, bool useStaticPlaceholderNames)
        {
            return useStaticPlaceholderNames ? helper.Placeholder(placeholderName) : DynamicPlaceholder(helper, placeholderName);
        }

        public static string CurrentLanguageCode(this SitecoreHelper helper)
        {
            var lang = RenderingContext.CurrentOrNull?.Rendering?.Item?.Language ?? Context.Language;
            if (lang != null)
                return lang.CultureInfo.TwoLetterISOLanguageName;

            return "en";
        }
    }
}