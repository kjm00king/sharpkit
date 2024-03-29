﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.button
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("input:submit, a, button", ".demo").button();
            new jQuery("a", ".demo").click(e => JsContext.@return(false));
        }
    }
}