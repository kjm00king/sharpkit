//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.slider
{
    #region Thumb
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Represents a single thumb element on a Slider. This would not usually be created manually and would instead
    /// be created internally by an <see cref="Ext.slider.Multi">Multi slider</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Thumb : Ext.Base
    {
        /// <summary>
        /// True to constrain the thumb so that it cannot overlap its siblings
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrain;
        /// <summary>
        /// The slider this thumb is contained within
        /// </summary>
        public Multi slider{get;set;}
        /// <summary>
        /// The number used internally to set the z index of the top thumb (see promoteThumb for details)
        /// </summary>
        private JsNumber topThumbZIndex{get;set;}
        /// <summary>
        /// Creates new slider thumb.
        /// </summary>
        /// <param name="config"><p>Config object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Thumb(object config=null){}
        /// <summary>
        /// Bring thumb dom element to front.
        /// </summary>
        private void bringToFront(){}
        /// <summary>
        /// Disables the thumb if it is currently enabled
        /// </summary>
        public void disable(){}
        /// <summary>
        /// Enables the thumb if it is currently disabled
        /// </summary>
        public void enable(){}
        /// <summary>
        /// Sets up an Ext.dd.DragTracker for this thumb
        /// </summary>
        public void initEvents(){}
        /// <summary>
        /// move the thumb
        /// </summary>
        /// <param name="v">
        /// </param>
        /// <param name="animate">
        /// </param>
        private void move(object v, object animate){}
        /// <summary>
        /// This is tied into the internal Ext.dd.DragTracker. If the slider is currently disabled,
        /// this returns false to disable the DragTracker too.
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>False if the slider is currently disabled</p>
        /// </div>
        /// </returns>
        private bool onBeforeDragStart(object e){return false;}
        /// <summary>
        /// This is tied into the internal Ext.dd.DragTracker's onDrag template method. This is called every time
        /// the DragTracker detects a drag movement. It updates the Slider's value using the position of the drag
        /// </summary>
        /// <param name="e">
        /// </param>
        protected virtual void onDrag(object e){}
        /// <summary>
        /// This is tied to the internal Ext.dd.DragTracker's onEnd template method. Removes the drag CSS class and
        /// fires the 'changecomplete' event with the new value
        /// </summary>
        /// <param name="e">
        /// </param>
        protected virtual void onDragEnd(object e){}
        /// <summary>
        /// This is tied into the internal Ext.dd.DragTracker's onStart template method. Adds the drag CSS class
        /// to the thumb and fires the 'dragstart' event
        /// </summary>
        /// <param name="e">
        /// </param>
        protected virtual void onDragStart(object e){}
        /// <summary>
        /// Renders the thumb into a slider
        /// </summary>
        public void render(){}
        /// <summary>
        /// Send thumb dom element to back.
        /// </summary>
        private void sendToBack(){}
        public Thumb(ThumbConfig config){}
        public Thumb(params object[] args){}
    }
    #endregion
    #region ThumbConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ThumbConfig : Ext.BaseConfig
    {
        /// <summary>
        /// True to constrain the thumb so that it cannot overlap its siblings
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrain;
        /// <summary>
        /// The Slider to render to.
        /// </summary>
        public Multi slider;
        public ThumbConfig(params object[] args){}
    }
    #endregion
    #region ThumbEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ThumbEvents : Ext.BaseEvents
    {
        public ThumbEvents(params object[] args){}
    }
    #endregion
}