//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.events
{

using SharpKit.JavaScript;
using AbstractView = org.w3c.dom.views.AbstractView;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class FocusEvent : UIEvent
{

	// FocusEvent
	public EventTarget relatedTarget {get;private set;}
	public void initFocusEvent(string typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, int detailArg, EventTarget relatedTargetArg) {}
}

}