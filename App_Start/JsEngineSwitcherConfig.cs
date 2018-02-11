using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Gary.XA.JsEngineSwitcherConfig), "Configure")]

namespace Gary.XA
{
    public static class JsEngineSwitcherConfig
    {
        public static void Configure()
        {
            JsEngineSwitcher engineSwitcher = JsEngineSwitcher.Instance;
            engineSwitcher.EngineFactories
                .AddV8(new V8Settings
                {
                })
                ;
            engineSwitcher.DefaultEngineName = V8JsEngine.EngineName;
        }
    }
}