﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.hide
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
            // set effect from select menu value
            new jQuery("#button").click(e =>
            {
                runEffect();
                JsContext.@return(false);
            });
        }

        // run the currently selected effect
        static void runEffect()
        {
            // get effect type from 
            var selectedEffect = new jQuery("#effectTypes").val().As<EffectType>();
            // most effect types need no options passed by default
            var options = new JsObject { };
            if (selectedEffect.ExactEquals("scale"))
            {
                //TODO
                JsContext.JsCode("options = { percent: 0 };");
            }
            else if (selectedEffect.ExactEquals("size"))
            {
                //TODO
                JsContext.JsCode("options = { to: { width: 200, height: 60 } };");
            }

            // run the effect
            new jQuery("#effect").hide(selectedEffect, options, 1000, callback);
        }

        static void callback(Event e, object ui)
        {
            HtmlContext.window.setTimeout(() =>
            {
                new jQuery("#effect").removeAttr("style").hide().fadeIn();
            }, 1000);
        }
    }
}