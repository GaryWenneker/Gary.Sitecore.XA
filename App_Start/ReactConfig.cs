using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Gary.XA.Feature.Media.ReactConfig), "Configure")]

namespace Gary.XA.Feature.Media
{
	public static class ReactConfig
	{
        public static void Configure()
        {
            ReactSiteConfiguration.Configuration
                //.DisableServerSideRendering() // add ?react-clientside=1 to querystring to disable server-side rendering per page request
                .SetReuseJavaScriptEngines(true)
                .SetLoadBabel(false)
                .SetUseDebugReact(true)
                //#if DEBUG
                //                .SetUseDebugReact(true)
                //#else
                //                .SetUseDebugReact(false)
                //#endif
                .SetJsonSerializerSettings(new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                })
                .SetLoadReact(false) // react is included in the server-side bundle
                .AddScriptWithoutTransform("~/scripts/server.bundle.js");
        }
    }
}