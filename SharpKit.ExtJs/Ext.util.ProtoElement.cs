//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.util
{
    #region ProtoElement
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Manages certain element-like data prior to rendering. These values are passed
    /// on to the render process. This is currently used to manage the "class" and "style" attributes
    /// of a component's primary el as well as the bodyEl of panels. This allows things like
    /// addBodyCls in Panel to share logic with addCls in AbstractComponent.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ProtoElement : Ext.Base
    {
        /// <summary>
        /// The property name for the className on the data object passed to writeTo.
        /// Defaults to: <c>&quot;cls&quot;</c>
        /// </summary>
        public JsString clsProp{get;set;}
        /// <summary>
        /// The property name for the removed classes on the data object passed to writeTo.
        /// Defaults to: <c>&quot;removed&quot;</c>
        /// </summary>
        public JsString removedProp{get;set;}
        /// <summary>
        /// True if the style must be converted to text during writeTo. When used to
        /// populate tpl data, this will be true. When used to populate Ext.DomHelper
        /// specs, this will be false (the default).
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool styleIsText{get;set;}
        /// <summary>
        /// The property name for the style on the data object passed to writeTo.
        /// Defaults to: <c>&quot;style&quot;</c>
        /// </summary>
        public JsString styleProp{get;set;}
        /// <summary>
        /// Adds class to the element.
        /// </summary>
        /// <param name="cls"><p>One or more classnames separated with spaces.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.util.ProtoElement">Ext.util.ProtoElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public ProtoElement addCls(JsString cls){return null;}
        /// <summary>
        /// Indicates that the current state of the object has been flushed to the DOM, so we need
        /// to track any subsequent changes
        /// </summary>
        public void flush(){}
        /// <summary>
        /// True if the element has given class.
        /// </summary>
        /// <param name="cls">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool hasCls(JsString cls){return false;}
        /// <summary>
        /// Removes class from the element.
        /// </summary>
        /// <param name="cls"><p>One or more classnames separated with spaces.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.util.ProtoElement">Ext.util.ProtoElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public ProtoElement removeCls(JsString cls){return null;}
        /// <summary>
        /// Adds styles to the element.
        /// </summary>
        /// <param name="prop"><p>The style property to be set, or an object of multiple styles.</p>
        /// </param>
        /// <param name="value"><p>The value to apply to the given property.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.util.ProtoElement">Ext.util.ProtoElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public ProtoElement setStyle(object prop, object value=null){return null;}
        /// <summary>
        /// Writes style and class properties to given object.
        /// Styles will be written to styleProp and class names to clsProp.
        /// </summary>
        /// <param name="to">
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>to</p>
        /// </div>
        /// </returns>
        public object writeTo(object to){return null;}
        public ProtoElement(ProtoElementConfig config){}
        public ProtoElement(){}
        public ProtoElement(params object[] args){}
    }
    #endregion
    #region ProtoElementConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ProtoElementConfig : Ext.BaseConfig
    {
        public ProtoElementConfig(params object[] args){}
    }
    #endregion
    #region ProtoElementEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ProtoElementEvents : Ext.BaseEvents
    {
        public ProtoElementEvents(params object[] args){}
    }
    #endregion
}
