﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI.Web;
namespace KendoUISamples.examples.web.window
{
    [JsType(JsMode.Global)]
    public class Events
    {
        public static jQuery win;
        public static jQuery undo;
        static Events()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            win = new jQuery("#window");
            undo = new jQuery("#undo")
                    .bind("click", e =>
                    {
                        win.data("kendoWindow").As<Window>().open();
                        undo.hide();
                    });

            if (win.data("kendoWindow") == null)
            {
                win.kendoWindow(new WindowConfiguration
                {
                    width = "630px",
                    height = "315px",
                    title = "Rams's Ten Principles of Good Design",
                    actions = new[] { "Refresh", "Close" },
                    contentString = "../../content/web/window/ajax/ajaxContent1.html",
                    open = onOpen,
                    activate = onActivate,
                    close = onClose,
                    deactivate = onDeactivate,
                    refresh = onRefresh,
                    resize = onResize,
                    dragstart = onDragStart,
                    dragend = onDragEnd
                });
            }
        }
        static void onOpen(Event e)
        {
            kendoConsole.log("event :: open");
        }

        static void onClose()
        {
            undo.show();
            kendoConsole.log("event :: close");
        }

        static void onActivate(Event e)
        {
            kendoConsole.log("event :: activate");
        }

        static void onDeactivate(Event e)
        {
            kendoConsole.log("event :: deactivate");
        }

        static void onRefresh(Event e)
        {
            kendoConsole.log("event :: refresh");
        }

        static void onResize(Event e)
        {
            kendoConsole.log("event :: resize");
        }

        static void onDragStart(Event e)
        {
            kendoConsole.log("event :: dragstart");
        }

        static void onDragEnd(Event e)
        {
            kendoConsole.log("event :: dragend");
        }
    }
}