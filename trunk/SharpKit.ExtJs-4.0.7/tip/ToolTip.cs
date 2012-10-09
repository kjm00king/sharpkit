//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.Unknown;
#region Ext.tip
namespace Ext.tip
{
    #region ToolTip
    /// <summary>
    /// ToolTip is a Ext.tip.Tip implementation that handles the common case of displaying a
    /// tooltip when hovering over a certain element or elements on the page. It allows fine-grained
    /// control over the tooltip&#39;s alignment relative to the target element or mouse, and the timing
    /// of when it is automatically shown and hidden. This implementation does not have a built-in method of automatically populating the tooltip&#39;s
    /// text based on the target element; you must either configure a fixed html value for each
    /// ToolTip instance, or implement custom logic (e.g. in a beforeshow event listener) to
    /// generate the appropriate tooltip content on the fly. See Ext.tip.QuickTip for a more
    /// convenient way of automatically populating and configuring a tooltip based on specific DOM
    /// attributes of each target element. Basic Example var tip = Ext.create(&#39;Ext.tip.ToolTip&#39;, {
    /// target: &#39;clearButton&#39;,
    /// html: &#39;Press this button to clear the form&#39;
    /// });
    /// Delegation In addition to attaching a ToolTip to a single element, you can also use delegation to attach
    /// one ToolTip to many elements under a common parent. This is more efficient than creating many
    /// ToolTip instances. To do this, point the target config to a common ancestor of all the
    /// elements, and then set the delegate config to a CSS selector that will select all the
    /// appropriate sub-elements. When using delegation, it is likely that you will want to programmatically change the content
    /// of the ToolTip based on each delegate element; you can do this by implementing a custom
    /// listener for the beforeshow event. Example: var store = Ext.create(&#39;Ext.data.ArrayStore&#39;, {
    /// fields: [&#39;company&#39;, &#39;price&#39;, &#39;change&#39;],
    /// data: [
    /// [&#39;3m Co&#39;,                               71.72, 0.02],
    /// [&#39;Alcoa Inc&#39;,                           29.01, 0.42],
    /// [&#39;Altria Group Inc&#39;,                    83.81, 0.28],
    /// [&#39;American Express Company&#39;,            52.55, 0.01],
    /// [&#39;American International Group, Inc.&#39;,  64.13, 0.31],
    /// [&#39;AT&amp;amp;T Inc.&#39;,                           31.61, -0.48]
    /// ]
    /// });
    /// var grid = Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Array Grid&#39;,
    /// store: store,
    /// columns: [
    /// {text: &#39;Company&#39;, flex: 1, dataIndex: &#39;company&#39;},
    /// {text: &#39;Price&#39;, width: 75, dataIndex: &#39;price&#39;},
    /// {text: &#39;Change&#39;, width: 75, dataIndex: &#39;change&#39;}
    /// ],
    /// height: 200,
    /// width: 400,
    /// renderTo: Ext.getBody()
    /// });
    /// grid.getView().on(&#39;render&#39;, function(view) {
    /// view.tip = Ext.create(&#39;Ext.tip.ToolTip&#39;, {
    /// // The overall target element.
    /// target: view.el,
    /// // Each grid row causes its own seperate show and hide.
    /// delegate: view.itemSelector,
    /// // Moving within the row should not hide the tip.
    /// trackMouse: true,
    /// // Render immediately so that tip.body can be referenced prior to the first show.
    /// renderTo: Ext.getBody(),
    /// listeners: {
    /// // Change content dynamically depending on which element triggered the show.
    /// beforeshow: function updateTipBody(tip) {
    /// tip.update(&#39;Over company &quot;&#39; + view.getRecord(tip.triggerElement).get(&#39;company&#39;) + &#39;&quot;&#39;);
    /// }
    /// }
    /// });
    /// });
    /// Alignment The following configuration properties allow control over how the ToolTip is aligned relative to
    /// the target element and/or mouse pointer:  anchor anchorToTarget anchorOffset trackMouse mouseOffset  Showing/Hiding The following configuration properties allow control over how and when the ToolTip is automatically
    /// shown and hidden:  autoHide showDelay hideDelay dismissDelay
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ToolTip : Ext.tip.Tip, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Hides this tooltip if visible. ...
        /// </summary>
        public object hide(){return null;}
        /// <summary>
        /// Binds this ToolTip to the specified element. ...
        /// </summary>
        public object setTarget(object t){return null;}
        /// <summary>
        /// Shows this tooltip at the current event target XY position. ...
        /// </summary>
        public new object show(){return null;}
        /// <summary>
        /// When a ToolTip is configured with the delegate
        /// option to cause selected child elements of the target
        /// Element to each ...
        /// </summary>
        public DOMElement triggerElement{get;set;}
        public ToolTip(ToolTipConfig config){}
        public ToolTip(){}
    }
    #endregion
    #region ToolTipConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ToolTipConfig : Ext.tip.TipConfig
    {
        /// <summary>
        /// If specified, indicates that the tip should be anchored to a
        /// particular side of the target element or mouse pointer (...
        /// </summary>
        public JsString anchor{get;set;}
        /// <summary>
        /// A numeric pixel value used to offset the
        /// default position of the anchor arrow (defaults to 0). ...
        /// </summary>
        public JsNumber anchorOffset{get;set;}
        /// <summary>
        /// True to anchor the tooltip to the target
        /// element, false to anchor it relative to the mouse coordinates (defaults
        /// to t...
        /// </summary>
        public bool anchorToTarget{get;set;}
        /// <summary>
        /// True to automatically hide the tooltip after the
        /// mouse exits the target element or after the dismissDelay
        /// has expired...
        /// </summary>
        public bool autoHide{get;set;}
        /// <summary>
        /// A DomQuery selector which allows selection of individual elements within the
        /// target element to trigger showing and hi...
        /// </summary>
        public JsString @delegate{get;set;}
        /// <summary>
        /// Delay in milliseconds before the tooltip
        /// automatically hides (defaults to 5000). ...
        /// </summary>
        public JsNumber dismissDelay{get;set;}
        /// <summary>
        /// Delay in milliseconds after the mouse exits the
        /// target element but before the tooltip actually hides (defaults to 200). ...
        /// </summary>
        public JsNumber hideDelay{get;set;}
        public JsArray mouseOffset{get;set;}
        public JsNumber showDelay{get;set;}
        public object target{get;set;}
        public bool trackMouse{get;set;}
    }
    #endregion
    #region ToolTipEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ToolTipEvents : Ext.tip.TipEvents
    {
    }
    #endregion
}
#endregion