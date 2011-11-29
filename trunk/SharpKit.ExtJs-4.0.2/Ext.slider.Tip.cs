//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.slider
namespace Ext.slider
{
    #region Tip
    /// <summary>
    /// Simple plugin for using an Ext.tip.Tip with a slider to show the slider value. In general this
    /// class is not created directly, instead pass the Ext.slider.Multi.useTips and
    /// Ext.slider.Multi.tipText configuration options to the slider directly.
    /// Example usage:     Ext.create(&#39;Ext.slider.Single&#39;, {
    /// width: 214,
    /// minValue: 0,
    /// maxValue: 100,
    /// useTips: true,
    /// renderTo: Ext.getBody()
    /// });
    /// Optionally provide your own tip text by passing tipText:  new Ext.slider.Single({
    /// width: 214,
    /// minValue: 0,
    /// maxValue: 100,
    /// useTips: true,
    /// tipText: function(thumb){
    /// return Ext.String.format(&#39;{0}% complete&#39;, thumb.value);
    /// }
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Tip : Ext.tip.Tip, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Used to create the text that appears in the Tip's body. ...
        /// </summary>
        public JsString getText(Thumb thumb){return null;}
        public Tip(Ext.slider.TipConfig config){}
        public Tip(){}
    }
    #endregion
    #region TipConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TipConfig : Ext.tip.TipConfig
    {
    }
    #endregion
    #region TipEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TipEvents : Ext.tip.TipEvents
    {
    }
    #endregion
}
#endregion