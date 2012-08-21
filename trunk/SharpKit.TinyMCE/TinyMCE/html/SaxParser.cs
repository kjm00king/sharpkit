//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.html
{
    /// <summary>
    /// This class parses HTML code using pure JavaScript and executes various events for each item it finds.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.html.SaxParser", Export=false)]
    public static  partial class SaxParser
    {
        /// <summary>
        /// Encoded the specified text with both the attributes and text entities. This function will produce larger text contents
        /// since it doesn't know if the context is within a attribute or text node. This was added for compatibility
        /// and is exposed as the DOMUtils.encode function.
        /// </summary>
        /// <param name="text">Text to encode.</param>
        public static string encodeAllRaw(string text){return null;}
        /// <summary>
        /// Encodes the specified string using named entities. The core entities will be encoded as named ones but all non lower ascii characters
        /// will be encoded into named entities.
        /// </summary>
        /// <param name="text">Text to encode.</param>
        /// <param name="attr">Optional flag to specify if the text is attribute contents.</param>
        /// <param name="entities">Optional parameter with entities to use.</param>
        public static string encodeNamed(string text, bool attr, object entities){return null;}
        /// <summary>
        /// Encodes the specified string using numeric entities. The core entities will be encoded as named ones but all non lower ascii characters
        /// will be encoded into numeric entities.
        /// </summary>
        /// <param name="text">Text to encode.</param>
        /// <param name="attr">Optional flag to specify if the text is attribute contents.</param>
        public static string encodeNumeric(string text, bool attr){return null;}
        /// <summary>
        /// Encodes the specified string using raw entities. This means only the required XML base entities will be endoded.
        /// </summary>
        /// <param name="text">Text to encode.</param>
        /// <param name="attr">Optional flag to specify if the text is attribute contents.</param>
        public static string encodeRaw(string text, bool attr){return null;}
        /// <summary>
        /// Returns an encode function based on the name(s) and it's optional entities.
        /// </summary>
        /// <param name="name">Comma separated list of encoders for example named,numeric.</param>
        /// <param name="entities">Optional parameter with entities to use instead of the built in set.</param>
        public static object getEncodeFunc(string name, string entities){return null;}
        /// <summary>
        /// Parses the specified HTML string and executes the callbacks for each item it finds.
        /// </summary>
        /// <param name="html">Html string to sax parse.</param>
        public static object parse(string html){return null;}
    }
}
