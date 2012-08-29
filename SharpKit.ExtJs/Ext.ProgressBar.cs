//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region ProgressBar
    /// <inheritdocs />
    /// <summary>
    /// <p>An updateable progress bar component. The progress bar supports two different modes: manual and automatic.</p>
    /// <p>In manual mode, you are responsible for showing, updating (via <see cref="Ext.ProgressBar.updateProgress">updateProgress</see>) and clearing the progress bar
    /// as needed from your own code. This method is most appropriate when you want to show progress throughout an operation
    /// that has predictable points of interest at which you can update the control.</p>
    /// <p>In automatic mode, you simply call <see cref="Ext.ProgressBar.wait">wait</see> and let the progress bar run indefinitely, only clearing it once the
    /// operation is complete. You can optionally have the progress bar wait for a specific amount of time and then clear
    /// itself. Automatic mode is most appropriate for timed operations or asynchronous operations in which you have no need
    /// for indicating intermediate progress.</p>
    /// <pre><code>var p = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.ProgressBar">Ext.ProgressBar</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// width: 300
    /// });
    /// // Wait for 5 seconds, then update the status el (progress bar will auto-reset)
    /// p.wait({
    /// interval: 500, //bar will move fast!
    /// duration: 50000,
    /// increment: 15,
    /// text: 'Updating...',
    /// scope: this,
    /// fn: function(){
    /// p.updateText('Done!');
    /// }
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ProgressBar : Ext.Component
    {
        /// <summary>
        /// The text shown in the progress bar.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString text;
        /// <summary>
        /// The element to render the progress text to (defaults to the progress bar's internal text element)
        /// </summary>
        public object textEl;
        /// <summary>
        /// A floating point value between 0 and 1 (e.g., .5)
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber value;
        /// <summary>
        /// Returns true if the progress bar is currently in a wait operation
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if waiting, else false</p>
        /// </div>
        /// </returns>
        public bool isWaiting(){return false;}
        /// <summary>
        /// Resets the progress bar value to 0 and text to empty string. If hide = true, the progress bar will also be hidden
        /// (using the hideMode property internally).
        /// </summary>
        /// <param name="hide"><p>True to hide the progress bar.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.ProgressBar">Ext.ProgressBar</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.ProgressBar reset(object hide=null){return null;}
        /// <summary>
        /// Updates the progress bar value, and optionally its text. If the text argument is not specified, any existing text
        /// value will be unchanged. To blank out existing text, pass ''. Note that even if the progress bar value exceeds 1,
        /// it will never automatically reset -- you are responsible for determining when the progress is complete and
        /// calling reset to clear and/or hide the control.
        /// </summary>
        /// <param name="value"><p>A floating point value between 0 and 1 (e.g., .5)</p>
        /// <p>Defaults to: <c>0</c></p></param>
        /// <param name="text"><p>The string to display in the progress text element</p>
        /// <p>Defaults to: <c>&quot;&quot;</c></p></param>
        /// <param name="animate"><p>Whether to animate the transition of the progress bar. If this value is not
        /// specified, the default for the class is used</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.ProgressBar">Ext.ProgressBar</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.ProgressBar updateProgress(object value=null, object text=null, object animate=null){return null;}
        /// <summary>
        /// Updates the progress bar text. If specified, textEl will be updated, otherwise the progress bar itself will
        /// display the updated text.
        /// </summary>
        /// <param name="text"><p>The string to display in the progress text element</p>
        /// <p>Defaults to: <c>&quot;&quot;</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.ProgressBar">Ext.ProgressBar</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.ProgressBar updateText(object text=null){return null;}
        /// <summary>
        /// Initiates an auto-updating progress bar. A duration can be specified, in which case the progress bar will
        /// automatically reset after a fixed amount of time and optionally call a callback function if specified. If no
        /// duration is passed in, then the progress bar will run indefinitely and must be manually cleared by calling
        /// reset.
        /// Example usage:
        /// <code>var p = new <see cref="Ext.ProgressBar">Ext.ProgressBar</see>({
        /// renderTo: 'my-el'
        /// });
        /// //Wait for 5 seconds, then update the status el (progress bar will auto-reset)
        /// var p = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.ProgressBar">Ext.ProgressBar</see>', {
        /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
        /// width: 300
        /// });
        /// //Wait for 5 seconds, then update the status el (progress bar will auto-reset)
        /// p.wait({
        /// interval: 500, //bar will move fast!
        /// duration: 50000,
        /// increment: 15,
        /// text: 'Updating...',
        /// scope: this,
        /// fn: function(){
        /// p.updateText('Done!');
        /// }
        /// });
        /// //Or update indefinitely until some async action completes, then reset manually
        /// p.wait();
        /// myAction.on('complete', function(){
        /// p.reset();
        /// p.updateText('Done!');
        /// });
        /// </code>
        /// </summary>
        /// <param name="config"><p>Configuration options</p>
        /// <ul><li><span>duration</span> : <see cref="Number">Number</see><div><p>The length of time in milliseconds that the progress bar should
        /// run before resetting itself (defaults to undefined, in which case it will run indefinitely
        /// until reset is called)</p>
        /// </div></li><li><span>interval</span> : <see cref="Number">Number</see><div><p>The length of time in milliseconds between each progress update
        /// (defaults to 1000 ms)</p>
        /// </div></li><li><span>animate</span> : <see cref="bool">Boolean</see><div><p>Whether to animate the transition of the progress bar. If this
        /// value is not specified, the default for the class is used.</p>
        /// </div></li><li><span>increment</span> : <see cref="Number">Number</see><div><p>The number of progress update segments to display within the
        /// progress bar (defaults to 10).  If the bar reaches the end and is still updating, it will
        /// automatically wrap back to the beginning.</p>
        /// </div></li><li><span>text</span> : <see cref="String">String</see><div><p>Optional text to display in the progress bar element (defaults to '').</p>
        /// </div></li><li><span>fn</span> : <see cref="Function">Function</see><div><p>A callback function to execute after the progress bar finishes auto-
        /// updating.  The function will be called with no arguments.  This function will be ignored if
        /// duration is not specified since in that case the progress bar can only be stopped programmatically,
        /// so any required function should be called by the same code after it resets the progress bar.</p>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div><p>The scope that is passed to the callback function (only applies when
        /// duration and fn are both passed).</p>
        /// </div></li></ul></param>
        /// <returns>
        /// <span><see cref="Ext.ProgressBar">Ext.ProgressBar</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.ProgressBar wait(object config=null){return null;}
        public ProgressBar(Ext.ProgressBarConfig config){}
        public ProgressBar(){}
        public ProgressBar(params object[] args){}
    }
    #endregion
    #region ProgressBarConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ProgressBarConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// True to animate the progress bar during transitions.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool animate;
        /// <summary>
        /// The text shown in the progress bar.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString text;
        /// <summary>
        /// The element to render the progress text to (defaults to the progress bar's internal text element)
        /// </summary>
        public object textEl;
        /// <summary>
        /// A floating point value between 0 and 1 (e.g., .5)
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber value;
        public ProgressBarConfig(params object[] args){}
    }
    #endregion
    #region ProgressBarEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ProgressBarEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires after each update interval
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="value"><p>The current progress value</p>
        /// </param>
        /// <param name="text"><p>The current progress text</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void update(Ext.ProgressBar @this, JsNumber value, JsString text, object eOpts){}
        public ProgressBarEvents(params object[] args){}
    }
    #endregion
}
