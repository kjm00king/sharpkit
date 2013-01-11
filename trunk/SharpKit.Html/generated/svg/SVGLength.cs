
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGLength.idl

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

namespace SharpKit.Html.svg
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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGLength")]
public partial class SvgLength
{
	public  static int SVG_LENGTHTYPE_UNKNOWN = 0;
	public  static int SVG_LENGTHTYPE_NUMBER = 1;
	public  static int SVG_LENGTHTYPE_PERCENTAGE = 2;
	public  static int SVG_LENGTHTYPE_EMS = 3;
	public  static int SVG_LENGTHTYPE_EXS = 4;
	public  static int SVG_LENGTHTYPE_PX = 5;
	public  static int SVG_LENGTHTYPE_CM = 6;
	public  static int SVG_LENGTHTYPE_MM = 7;
	public  static int SVG_LENGTHTYPE_IN = 8;
	public  static int SVG_LENGTHTYPE_PT = 9;
	public  static int SVG_LENGTHTYPE_PC = 10;
	public  int unitType {get; set; }
	public  double value {get; set; }
	public  double valueInSpecifiedUnits {get; set; }
	public  JsString valueAsString {get; set; }
	public  void newValueSpecifiedUnits(int unitType, double valueInSpecifiedUnits) {}
	public  void convertToSpecifiedUnits(int unitType) {}
}

}