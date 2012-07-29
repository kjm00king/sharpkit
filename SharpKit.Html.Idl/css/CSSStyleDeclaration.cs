
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:27:56 GMT

  Content was generated from IDL file:
	http://trac.webkit.org/browser/trunk/Source/WebCore/css/CSSStyleDeclaration.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

	Copyright (C) 2012 Sebastian Loncar
	Copyright (C) 2009 Apple Inc. All Rights Reserved.

	MIT License:

	Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
	associated documentation files (the "Software"), to deal in the Software without restriction, 
	including without limitation the rights to use, copy, modify, merge, publish, distribute,
	sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in all copies or substantial
	portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
	NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
	NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
	OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
	CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, NativeEnumerator = false, NativeArrayEnumerator = true, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "CSSStyleDeclaration")]
public partial class CssStyleDeclaration : IJsArrayEnumerable<JsString>
{
	public  JsString cssText {get; set; }
	public  JsString getPropertyValue(string propertyName) { return default(JsString); }
	public  CssValue getPropertyCSSValue(string propertyName) { return default(CssValue); }
	public  JsString removeProperty(string propertyName) { return default(JsString); }
	public  JsString getPropertyPriority(string propertyName) { return default(JsString); }
	public  void setProperty(string propertyName, string value, string priority) {}
	public  int length {get; set; }
	[JsProperty(NativeIndexer = true)]
	public  JsString this[int index] {get { return default(JsString); } set {}}
	public  CssRule parentRule {get; set; }
	public  JsString getPropertyShorthand(string propertyName) { return default(JsString); }
	public  bool isPropertyImplicit(string propertyName) { return default(bool); }

	JsString IJsArrayEnumerable<JsString>.this[JsNumber index] {
		get { throw new NotImplementedException(); }
	}

	JsNumber IJsArrayEnumerable<JsString>.length {
		get { throw new NotImplementedException(); }
	}

	System.Collections.Generic.IEnumerator<JsString> System.Collections.Generic.IEnumerable<JsString>.GetEnumerator() {
		throw new NotImplementedException();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
		throw new NotImplementedException();
	}
}

}