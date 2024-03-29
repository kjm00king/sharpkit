//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.fx
{
    #region Manager
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Animation Manager which keeps track of all current animations and manages them on a frame by frame basis.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Manager : Ext.Base, Ext.fx.Queue
    {
        /// <summary>
        /// Force the use of JavaScript-based animation instead of CSS3 animation, even when CSS3
        /// animation is supported by the browser. This defaults to true currently, as CSS3 animation support is still
        /// considered experimental at this time, and if used should be thouroughly tested across all targeted browsers.
        /// Defaults to: <c>true</c>
        /// </summary>
        public static bool forceJS;
        /// <summary>
        /// Default interval in miliseconds to calculate each frame.  Defaults to 16ms (~60fps)
        /// Defaults to: <c>16</c>
        /// </summary>
        public static JsNumber interval;
        /// <summary>
        /// Add an Anim to the manager. This is done automatically when an Anim instance is created.
        /// </summary>
        /// <param name="anim">
        /// </param>
        public static void addAnim(Anim anim){}
        /// <summary>
        /// Apply all pending attribute changes to their targets
        /// </summary>
        private static void applyPendingAttrs(){}
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// constructor: function() {
        /// alert("I'm a cat!");
        /// }
        /// });
        /// My.Cat.override({
        /// constructor: function() {
        /// alert("I'm going to be a cat!");
        /// this.callOverridden();
        /// alert("Meeeeoooowwww");
        /// }
        /// });
        /// var kitty = new My.Cat(); // alerts "I'm going to be a cat!"
        /// // alerts "I'm a cat!"
        /// // alerts "Meeeeoooowwww"
        /// </code>
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>as of 4.1. Use <see cref="Ext.Base.callParent">callParent</see> instead.</p>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callOverridden(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the overridden method</p>
        /// </div>
        /// </returns>
        protected static object callOverridden(object args=null){return null;}
        /// <summary>
        /// Call the "parent" method of the current method. That is the method previously
        /// overridden by derivation or by an override (see Ext.define).
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Base', {
        /// constructor: function (x) {
        /// this.x = x;
        /// },
        /// statics: {
        /// method: function (x) {
        /// return x;
        /// }
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived', {
        /// extend: 'My.Base',
        /// constructor: function () {
        /// this.callParent([21]);
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // alerts 21
        /// </code>
        /// This can be used with an override as follows:
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.DerivedOverride', {
        /// override: 'My.Derived',
        /// constructor: function (x) {
        /// this.callParent([x*2]); // calls original My.Derived constructor
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // now alerts 42
        /// </code>
        /// This also works with static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2', {
        /// extend: 'My.Base',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Base.method
        /// }
        /// }
        /// });
        /// alert(My.Base.method(10);     // alerts 10
        /// alert(My.Derived2.method(10); // alerts 20
        /// </code>
        /// Lastly, it also works with overridden static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2Override', {
        /// override: 'My.Derived2',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Derived2.method
        /// }
        /// }
        /// });
        /// alert(My.Derived2.method(10); // now alerts 40
        /// </code>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callParent(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the parent method</p>
        /// </div>
        /// </returns>
        protected static object callParent(object args=null){return null;}
        /// <summary>
        /// Collect target attributes for the given Anim object at the given timestamp
        /// </summary>
        /// <param name="anim"><p>The Anim instance</p>
        /// </param>
        /// <param name="timestamp"><p>Time after the anim's start time</p>
        /// </param>
        /// <param name="useCSS3"><p>True if using CSS3-based animation, else false</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="isLastFrame"><p>True if this is the last frame of animation to be run, else false</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The animation target wrapper object containing the passed animation along with the
        /// new attributes to set on the target's element in the next animation frame.</p>
        /// </div>
        /// </returns>
        private static object collectTargetData(Anim anim, JsNumber timestamp, object useCSS3=null, object isLastFrame=null){return null;}
        /// <summary>
        /// </summary>
        private static void configClass(){}
        /// <summary>
        /// Overrides: <see cref="Ext.AbstractComponent.destroy">Ext.AbstractComponent.destroy</see>, <see cref="Ext.AbstractPlugin.destroy">Ext.AbstractPlugin.destroy</see>, <see cref="Ext.layout.Layout.destroy">Ext.layout.Layout.destroy</see>
        /// </summary>
        private static void destroy(){}
        /// <summary>
        /// Returns current animation object if the element has any effects actively running or queued, else returns false.
        /// </summary>
        /// <param name="targetId">
        /// </param>
        public virtual void getActiveAnimation(object targetId){}
        /// <summary>
        /// Parameters<li><span>name</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="name">
        /// </param>
        private static void getConfig(object name){}
        /// <summary>
        /// Returns the initial configuration passed to constructor when instantiating
        /// this class.
        /// </summary>
        /// <param name="name"><p>Name of the config option to return.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see>/Mixed</span><div><p>The full config object or a single config value
        /// when <c>name</c> parameter specified.</p>
        /// </div>
        /// </returns>
        public static object getInitialConfig(object name=null){return null;}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        private static void hasConfig(object config){}
        /// <summary>
        /// Initialize configuration for this class. a typical example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.awesome.Class', {
        /// // The default config
        /// config: {
        /// name: 'Awesome',
        /// isAwesome: true
        /// },
        /// constructor: function(config) {
        /// this.initConfig(config);
        /// }
        /// });
        /// var awesome = new My.awesome.Class({
        /// name: 'Super Awesome'
        /// });
        /// alert(awesome.getName()); // 'Super Awesome'
        /// </code>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Base">Ext.Base</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        protected static Ext.Base initConfig(object config){return null;}
        /// <summary>
        /// Parameters<li><span>names</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>callback</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="names">
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="scope">
        /// </param>
        private static void onConfigUpdate(object names, object callback, object scope){}
        /// <summary>
        /// Remove an Anim from the manager. This is done automatically when an Anim ends.
        /// </summary>
        /// <param name="anim">
        /// </param>
        public static void removeAnim(Anim anim){}
        /// <summary>
        /// Run the individual animation for this frame
        /// </summary>
        /// <param name="anim">
        /// </param>
        private static void runAnim(object anim){}
        /// <summary>
        /// Runner function being called each frame
        /// </summary>
        private static void runner(){}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>applyIfNotSet</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <param name="applyIfNotSet">
        /// </param>
        private static void setConfig(object config, object applyIfNotSet){}
        /// <summary>
        /// Start the individual animation (initialization)
        /// </summary>
        /// <param name="anim">
        /// </param>
        private static void startAnim(object anim){}
        /// <summary>
        /// Get the reference to the class from which this object was instantiated. Note that unlike self,
        /// this.statics() is scope-independent and it always returns the class from which it was called, regardless of what
        /// this points to during run-time
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// totalCreated: 0,
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// var statics = this.statics();
        /// alert(statics.speciesName);     // always equals to 'Cat' no matter what 'this' refers to
        /// // equivalent to: My.Cat.speciesName
        /// alert(this.self.speciesName);   // dependent on 'this'
        /// statics.totalCreated++;
        /// },
        /// clone: function() {
        /// var cloned = new this.self;                      // dependent on 'this'
        /// cloned.groupName = this.statics().speciesName;   // equivalent to: My.Cat.speciesName
        /// return cloned;
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'     // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// },
        /// constructor: function() {
        /// this.callParent();
        /// }
        /// });
        /// var cat = new My.Cat();                 // alerts 'Cat', then alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard(); // alerts 'Cat', then alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));         // alerts 'My.SnowLeopard'
        /// alert(clone.groupName);                 // alerts 'Cat'
        /// alert(My.Cat.totalCreated);             // alerts 3
        /// </code>
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Class">Ext.Class</see></span><div>
        /// </div>
        /// </returns>
        protected static Class statics(){return null;}
        public Manager(Ext.fx.ManagerConfig config){}
        public Manager(){}
        public Manager(params object[] args){}
    }
    #endregion
    #region ManagerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ManagerConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Force the use of JavaScript-based animation instead of CSS3 animation, even when CSS3
        /// animation is supported by the browser. This defaults to true currently, as CSS3 animation support is still
        /// considered experimental at this time, and if used should be thouroughly tested across all targeted browsers.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool forceJS;
        /// <summary>
        /// Default interval in miliseconds to calculate each frame.  Defaults to 16ms (~60fps)
        /// Defaults to: <c>16</c>
        /// </summary>
        public JsNumber interval;
        public ManagerConfig(params object[] args){}
    }
    #endregion
    #region ManagerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ManagerEvents : Ext.BaseEvents
    {
        public ManagerEvents(params object[] args){}
    }
    #endregion
}
