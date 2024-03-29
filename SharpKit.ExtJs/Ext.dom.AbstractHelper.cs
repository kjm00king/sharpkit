//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dom
{
    #region AbstractHelper
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Abstract base class for <see cref="Ext.dom.Helper">Ext.dom.Helper</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractHelper : Ext.Base
    {
        /// <summary>
        /// Creates new DOM element(s) and appends them to el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public object append(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Applies a style specification to an element.
        /// </summary>
        /// <param name="el"><p>The element to apply styles to</p>
        /// </param>
        /// <param name="styles"><p>A style specification string e.g. 'width:100px', or object in the form {width:'100px'}, or
        /// a function which returns such a specification.</p>
        /// </param>
        public void applyStyles(object el, object styles){}
        /// <summary>
        /// Converts the styles from the given object to text. The styles are CSS style names
        /// with their associated value.
        /// The basic form of this method returns a string:
        /// <code> var s = <see cref="Ext.DomHelper.generateStyles">Ext.DomHelper.generateStyles</see>({
        /// backgroundColor: 'red'
        /// });
        /// // s = 'background-color:red;'
        /// </code>
        /// Alternatively, this method can append to an output array.
        /// <code> var buf = [];
        /// ...
        /// <see cref="Ext.DomHelper.generateStyles">Ext.DomHelper.generateStyles</see>({
        /// backgroundColor: 'red'
        /// }, buf);
        /// </code>
        /// In this case, the style text is pushed on to the array and the array is returned.
        /// </summary>
        /// <param name="styles"><p>The object describing the styles.</p>
        /// </param>
        /// <param name="buffer"><p>The output buffer.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see>/<see cref="String">String</see>[]</span><div><p>If buffer is passed, it is returned. Otherwise the style
        /// string is returned.</p>
        /// </div>
        /// </returns>
        public object[] generateStyles(object styles, object buffer=null){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them after el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children)</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public object insertAfter(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them before el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public object insertBefore(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them as the first child of el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public object insertFirst(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Inserts an HTML fragment into the DOM.
        /// </summary>
        /// <param name="where"><p>Where to insert the html in relation to el - beforeBegin, afterBegin, beforeEnd, afterEnd.</p>
        /// <p>For example take the following HTML: <c>&lt;div&gt;Contents&lt;/div&gt;</c></p>
        /// <p>Using different <c>where</c> values inserts element to the following places:</p>
        /// <ul>
        /// <li>beforeBegin: <c>&lt;HERE&gt;&lt;div&gt;Contents&lt;/div&gt;</c></li>
        /// <li>afterBegin: <c>&lt;div&gt;&lt;HERE&gt;Contents&lt;/div&gt;</c></li>
        /// <li>beforeEnd: <c>&lt;div&gt;Contents&lt;HERE&gt;&lt;/div&gt;</c></li>
        /// <li>afterEnd: <c>&lt;div&gt;Contents&lt;/div&gt;&lt;HERE&gt;</c></li>
        /// </ul>
        /// </param>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="html"><p>The HTML fragment</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement</span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public JsObject insertHtml(object where, object el, JsString html){return null;}
        /// <summary>
        /// Returns the markup for the passed Element(s) config.
        /// </summary>
        /// <param name="spec"><p>The DOM object spec (and children)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public JsString markup(object spec){return null;}
        /// <summary>
        /// Creates new DOM element(s) and overwrites the contents of el with them.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public object overwrite(object el, object o, object returnElement=null){return null;}
        public AbstractHelper(AbstractHelperConfig config){}
        public AbstractHelper(){}
        public AbstractHelper(params object[] args){}
    }
    #endregion
    #region AbstractHelperConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractHelperConfig : Ext.BaseConfig
    {
        public AbstractHelperConfig(params object[] args){}
    }
    #endregion
    #region AbstractHelperEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractHelperEvents : Ext.BaseEvents
    {
        public AbstractHelperEvents(params object[] args){}
    }
    #endregion
}
