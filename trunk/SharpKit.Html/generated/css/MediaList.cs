
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/css/MediaList.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2013 Sebastian Loncar, Web: http://loncar.de
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
using SharpKit.Html.fileapi;
using SharpKit.Html.html.shadow;
using SharpKit.Html.html.track;
using SharpKit.Html.inspector;
using SharpKit.Html.loader.appcache;
using SharpKit.Html.modules.battery;
using SharpKit.Html.modules.filesystem;
using SharpKit.Html.modules.gamepad;
using SharpKit.Html.modules.geolocation;
using SharpKit.Html.modules.indexeddb;
using SharpKit.Html.modules.intents;
using SharpKit.Html.modules.mediasource;
using SharpKit.Html.modules.mediastream;
using SharpKit.Html.modules.navigatorcontentutils;
using SharpKit.Html.modules.networkinfo;
using SharpKit.Html.modules.notifications;
using SharpKit.Html.modules.proximity;
using SharpKit.Html.modules.quota;
using SharpKit.Html.modules.speech;
using SharpKit.Html.modules.vibration;
using SharpKit.Html.modules.webaudio;
using SharpKit.Html.modules.webdatabase;
using SharpKit.Html.plugins;
using SharpKit.Html.storage;
using SharpKit.Html.svg;
using SharpKit.Html.workers;
using SharpKit.Html.xml;

[JsType(JsMode.Prototype, NativeEnumerator = false, NativeArrayEnumerator = true, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "MediaList")]
public partial class MediaList : IJsArrayEnumerable<JsString>
{
	public  JsString mediaText {get; set; }
	public  int length {get; set; }
	[JsProperty(NativeIndexer = true)]
	public  JsString this[int index] {get { return default(JsString); } set {}}
	public  void deleteMedium(string oldMedium) {}
	public  void appendMedium(string newMedium) {}

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