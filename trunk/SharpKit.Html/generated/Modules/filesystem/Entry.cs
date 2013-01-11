
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/filesystem/Entry.idl

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

namespace SharpKit.Html.modules.filesystem
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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Entry")]
public partial class Entry
{
	public  bool isFile {get; set; }
	public  bool isDirectory {get; set; }
	public  JsString name {get; set; }
	public  JsString fullPath {get; set; }
	public  DOMFileSystem filesystem {get; set; }
	public  void getMetadata(MetadataCallback successCallback) {}
	public  void getMetadata(MetadataCallback successCallback, ErrorCallback errorCallback) {}
	public  void moveTo(DirectoryEntry parent) {}
	public  void moveTo(DirectoryEntry parent, string name) {}
	public  void moveTo(DirectoryEntry parent, string name, EntryCallback successCallback) {}
	public  void moveTo(DirectoryEntry parent, string name, EntryCallback successCallback, ErrorCallback errorCallback) {}
	public  void copyTo(DirectoryEntry parent) {}
	public  void copyTo(DirectoryEntry parent, string name) {}
	public  void copyTo(DirectoryEntry parent, string name, EntryCallback successCallback) {}
	public  void copyTo(DirectoryEntry parent, string name, EntryCallback successCallback, ErrorCallback errorCallback) {}
	public  JsString toURL() { return default(JsString); }
	public  void remove(VoidCallback successCallback) {}
	public  void remove(VoidCallback successCallback, ErrorCallback errorCallback) {}
	public  void getParent() {}
	public  void getParent(EntryCallback successCallback) {}
	public  void getParent(EntryCallback successCallback, ErrorCallback errorCallback) {}
}

}