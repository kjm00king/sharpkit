<h1>Example: using JavaScript API in C#</h1>
The following example illustrates how to use the C# Model classes to write native JavaScript code.

<a href='http://sharpkit.googlecode.com/svn/trunk/samples/SharpKitSamples.JavaScriptAPI/index.htm'>Run this example</a>

```
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace SharpKitSamples.JavaScriptAPI
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		static index()
		{
			//Example: using native JavaScript API in C#
			document.writeln("using JsDate...<br/>");
			var date = new JsDate();
			document.writeln("Local time is: " + date.toString());
			document.writeln("<br/>");

			document.writeln("using JsString...<br/>");
			var str = "Invoking JsString.italics()".As<JsString>().italics();
			document.writeln(str);
			document.writeln("<br/>");

			document.writeln("using JsMath...<br/>");
			document.writeln("Invoking JsMath.random() -> " + JsMath.random().toString());
			document.writeln("<br/>");
		}
	}
}

```

The JavaScript code that was generated by SharpKit:
```
//@AutoGenerated
document.writeln("using JsDate...<br/>");
var date = new Date();
document.writeln("Local time is: " + date.toString());
document.writeln("<br/>");
document.writeln("using JsString...<br/>");
var str = "Invoking JsString.italics()".italics();
document.writeln(str);
document.writeln("<br/>");
document.writeln("using JsMath...<br/>");
document.writeln("Invoking JsMath.random() -> " + Math.random().toString());
document.writeln("<br/>");
```

Sample output
<pre>
using JsDate...<br>
Local time is: Fri Jan 29 01:49:54 UTC+0200 2010<br>
<br>
using JsString...<br>
Invoking JsString.italics()<br>
<br>
using JsMath...<br>
Invoking JsMath.random() -> 0.4205741667695668<br>
</pre>