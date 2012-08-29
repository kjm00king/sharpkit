//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region String
    /// <summary>
    /// <p>A collection of useful static methods to deal with strings</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class String
    {
        /// <summary>
        /// Adds a set of character entity definitions to the set used by
        /// htmlEncode and htmlDecode.
        /// This object should be keyed by the entity name sequence,
        /// with the value being the textual representation of the entity.
        /// <code> <see cref="Ext.String.addCharacterEntities">Ext.String.addCharacterEntities</see>({
        /// '&amp;amp;Uuml;':'Ü',
        /// '&amp;amp;ccedil;':'ç',
        /// '&amp;amp;ntilde;':'ñ',
        /// '&amp;amp;egrave;':'è'
        /// });
        /// var s = <see cref="Ext.String.htmlEncode">Ext.String.htmlEncode</see>("A string with entities: èÜçñ");
        /// </code>
        /// Note: the values of the character entites defined on this object are expected
        /// to be single character values.  As such, the actual values represented by the
        /// characters are sensitive to the character encoding of the javascript source
        /// file when defined in string literal form. Script tasgs referencing server
        /// resources with character entities must ensure that the 'charset' attribute
        /// of the script node is consistent with the actual character encoding of the
        /// server resource.
        /// The set of character entities may be reset back to the default state by using
        /// the <see cref="Ext.String.resetCharacterEntities">resetCharacterEntities</see> method
        /// </summary>
        /// <param name="entities"><p>The set of character entities to add to the current
        /// definitions.</p>
        /// </param>
        public static void addCharacterEntities(object entities){}
        /// <summary>
        /// Capitalize the given string
        /// </summary>
        /// <param name="string">
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public static JsString capitalize(JsString @string){return null;}
        /// <summary>
        /// Converts a string of characters into a legal, parseable Javascript var name as long as the passed
        /// string contains at least one alphabetic character. Non alphanumeric characters, and leading non alphabetic
        /// characters will be removed.
        /// </summary>
        /// <param name="s"><p>A string to be converted into a <c>var</c> name.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>A legal Javascript <c>var</c> name.</p>
        /// </div>
        /// </returns>
        public static JsString createVarName(JsString s){return null;}
        /// <summary>
        /// Truncate a string and add an ellipsis ('...') to the end if it exceeds the specified length
        /// </summary>
        /// <param name="value"><p>The string to truncate</p>
        /// </param>
        /// <param name="length"><p>The maximum length to allow before truncating</p>
        /// </param>
        /// <param name="word"><p>True to try to find a common word break</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The converted text</p>
        /// </div>
        /// </returns>
        public static JsString ellipsis(JsString value, JsNumber length, bool word){return null;}
        /// <summary>
        /// Escapes the passed string for ' and \
        /// </summary>
        /// <param name="string"><p>The string to escape</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The escaped string</p>
        /// </div>
        /// </returns>
        public static JsString escape(JsString @string){return null;}
        /// <summary>
        /// Escapes the passed string for use in a regular expression
        /// </summary>
        /// <param name="string">
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public static JsString escapeRegex(JsString @string){return null;}
        /// <summary>
        /// Allows you to define a tokenized string and pass an arbitrary number of arguments to replace the tokens.  Each
        /// token must be unique, and must increment in the format {0}, {1}, etc.  Example usage:
        /// <code>    var cls = 'my-class', text = 'Some text';
        /// var s = <see cref="Ext.String.format">Ext.String.format</see>('&lt;div class="{0}">{1}&lt;/div>', cls, text);
        /// // s now contains the string: '&lt;div class="my-class">Some text&lt;/div>'
        /// </code>
        /// </summary>
        /// <param name="string"><p>The tokenized string to be formatted</p>
        /// </param>
        /// <param name="value1"><p>The value to replace token {0}</p>
        /// </param>
        /// <param name="value2"><p>Etc...</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The formatted string</p>
        /// </div>
        /// </returns>
        public static JsString format(JsString @string, JsString value1, JsString value2){return null;}
        /// <summary>
        /// Convert certain characters (&amp;, &lt;, >, ', and ") from their HTML character equivalents.
        /// </summary>
        /// <param name="value"><p>The string to decode</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The decoded text</p>
        /// </div>
        /// </returns>
        public static JsString htmlDecode(JsString value){return null;}
        /// <summary>
        /// Convert certain characters (&amp;, &lt;, >, ', and ") to their HTML character equivalents for literal display in web pages.
        /// </summary>
        /// <param name="value"><p>The string to encode</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The encoded text</p>
        /// </div>
        /// </returns>
        public static JsString htmlEncode(JsString value){return null;}
        /// <summary>
        /// Pads the left side of a string with a specified character.  This is especially useful
        /// for normalizing number and date strings.  Example usage:
        /// <code>    var s = <see cref="Ext.String.leftPad">Ext.String.leftPad</see>('123', 5, '0');
        /// // s now contains the string: '00123'
        /// </code>
        /// </summary>
        /// <param name="string"><p>The original string</p>
        /// </param>
        /// <param name="size"><p>The total length of the output string</p>
        /// </param>
        /// <param name="character"><p>The character with which to pad the original string (defaults to empty string " ")</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The padded string</p>
        /// </div>
        /// </returns>
        public static JsString leftPad(JsString @string, JsNumber size, object character=null){return null;}
        /// <summary>
        /// Returns a string with a specified number of repititions a given string pattern.
        /// The pattern be separated by a different string.
        /// <code> var s = <see cref="Ext.String.repeat">Ext.String.repeat</see>('---', 4); // = '------------'
        /// var t = <see cref="Ext.String.repeat">Ext.String.repeat</see>('--', 3, '/'); // = '--/--/--'
        /// </code>
        /// </summary>
        /// <param name="pattern"><p>The pattern to repeat.</p>
        /// </param>
        /// <param name="count"><p>The number of times to repeat the pattern (may be 0).</p>
        /// </param>
        /// <param name="sep"><p>An option string to separate each pattern.</p>
        /// </param>
        public static void repeat(JsString pattern, JsNumber count, JsString sep){}
        /// <summary>
        /// Resets the set of character entity definitions used by
        /// htmlEncode and htmlDecode back to the
        /// default state.
        /// </summary>
        public static void resetCharacterEntities(){}
        /// <summary>
        /// Splits a string of space separated words into an array, trimming as needed. If the
        /// words are already an array, it is returned.
        /// </summary>
        /// <param name="words">
        /// </param>
        public static void splitWords(object words){}
        /// <summary>
        /// Utility function that allows you to easily switch a string between two alternating values.  The passed value
        /// is compared to the current string, and if they are equal, the other value that was passed in is returned.  If
        /// they are already different, the first value passed in is returned.  Note that this method returns the new value
        /// but does not change the current string.
        /// <code>        // alternate sort directions
        /// sort = <see cref="Ext.String.toggle">Ext.String.toggle</see>(sort, 'ASC', 'DESC');
        /// // instead of conditional logic:
        /// sort = (sort == 'ASC' ? 'DESC' : 'ASC');
        /// </code>
        /// </summary>
        /// <param name="string"><p>The current string</p>
        /// </param>
        /// <param name="value"><p>The value to compare to the current string</p>
        /// </param>
        /// <param name="other"><p>The new value to use if the string already equals the first value passed in</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The new value</p>
        /// </div>
        /// </returns>
        public static JsString toggle(JsString @string, JsString value, JsString other){return null;}
        /// <summary>
        /// Trims whitespace from either end of a string, leaving spaces within the string intact.  Example:
        /// @example
        /// <code>var s = '  foo bar  ';
        /// alert('-' + s + '-');         //alerts "- foo bar -"
        /// alert('-' + <see cref="Ext.String.trim">Ext.String.trim</see>(s) + '-');  //alerts "-foo bar-"
        /// </code>
        /// </summary>
        /// <param name="string"><p>The string to escape</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The trimmed string</p>
        /// </div>
        /// </returns>
        public static JsString trim(JsString @string){return null;}
        /// <summary>
        /// Uncapitalize the given string
        /// </summary>
        /// <param name="string">
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public static JsString uncapitalize(JsString @string){return null;}
        /// <summary>
        /// Appends content to the query string of a URL, handling logic for whether to place
        /// a question mark or ampersand.
        /// </summary>
        /// <param name="url"><p>The URL to append to.</p>
        /// </param>
        /// <param name="string"><p>The content to append to the URL.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The resulting URL</p>
        /// </div>
        /// </returns>
        public static JsString urlAppend(JsString url, JsString @string){return null;}
        public String(StringConfig config){}
        public String(){}
        public String(params object[] args){}
    }
    #endregion
    #region StringConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class StringConfig
    {
        public StringConfig(params object[] args){}
    }
    #endregion
    #region StringEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class StringEvents
    {
        public StringEvents(params object[] args){}
    }
    #endregion
}
