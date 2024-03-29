//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.css
{

using SharpKit.JavaScript;
using DOMException = org.w3c.dom.DOMException;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class CSSPrimitiveValue : CSSValue
{

	// CSSPrimitiveValue
	public static short CSS_UNKNOWN = 0;
	public static short CSS_NUMBER = 1;
	public static short CSS_PERCENTAGE = 2;
	public static short CSS_EMS = 3;
	public static short CSS_EXS = 4;
	public static short CSS_PX = 5;
	public static short CSS_CM = 6;
	public static short CSS_MM = 7;
	public static short CSS_IN = 8;
	public static short CSS_PT = 9;
	public static short CSS_PC = 10;
	public static short CSS_DEG = 11;
	public static short CSS_RAD = 12;
	public static short CSS_GRAD = 13;
	public static short CSS_MS = 14;
	public static short CSS_S = 15;
	public static short CSS_HZ = 16;
	public static short CSS_KHZ = 17;
	public static short CSS_DIMENSION = 18;
	public static short CSS_STRING = 19;
	public static short CSS_URI = 20;
	public static short CSS_IDENT = 21;
	public static short CSS_ATTR = 22;
	public static short CSS_COUNTER = 23;
	public static short CSS_RECT = 24;
	public static short CSS_RGBCOLOR = 25;
	public short primitiveType {get;private set;}
	public void setFloatValue(short unitType, float floatValue) {}
	public float getFloatValue(short unitType) { return default(float); }
	public string stringValue {get;set;}
	public Counter counterValue {get;private set;}
	public Rect rectValue {get;private set;}
	public RGBColor rGBColorValue {get;private set;}
}

}