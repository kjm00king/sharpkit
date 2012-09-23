
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Thu, 20 Sep 2012 15:27:32 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/dom/NamedNodeMap.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de
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

[JsType(JsMode.Prototype, NativeEnumerator = false, NativeArrayEnumerator = true, Export = false, PropertiesAsFields = true, NativeCasts = true)]
public partial class NamedNodeMap : IJsArrayEnumerable<Node>
{
	public  Node getNamedItem(string name) { return default(Node); }
	public  Node setNamedItem(Node node) { return default(Node); }
	public  Node removeNamedItem(string name) { return default(Node); }
	[JsProperty(NativeIndexer = true)]
	public  Node this[int index] {get { return default(Node); } set {}}
	public  int length {get; set; }
	public  Node getNamedItemNS(string namespaceURI, string localName) { return default(Node); }
	public  Node setNamedItemNS(Node node) { return default(Node); }
	public  Node removeNamedItemNS(string namespaceURI, string localName) { return default(Node); }

	Node IJsArrayEnumerable<Node>.this[JsNumber index] {
		get { throw new NotImplementedException(); }
	}

	JsNumber IJsArrayEnumerable<Node>.length {
		get { throw new NotImplementedException(); }
	}

	System.Collections.Generic.IEnumerator<Node> System.Collections.Generic.IEnumerable<Node>.GetEnumerator() {
		throw new NotImplementedException();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
		throw new NotImplementedException();
	}
}

}