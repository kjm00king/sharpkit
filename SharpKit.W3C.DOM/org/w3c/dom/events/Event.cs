//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.events
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class Event
{

	// Event
	public static short CAPTURING_PHASE = 1;
	public static short AT_TARGET = 2;
	public static short BUBBLING_PHASE = 3;
	public string type {get;private set;}
	public EventTarget target {get;private set;}
	public EventTarget currentTarget {get;private set;}
	public short eventPhase {get;private set;}
	public bool bubbles {get;private set;}
	public bool cancelable {get;private set;}
	public long timeStamp {get;private set;}
	public void stopPropagation() {}
	public void preventDefault() {}
	public void initEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg) {}
	public void stopImmediatePropagation() {}
	public bool defaultPrevented {get;private set;}
	public bool trusted {get;private set;}
}

}