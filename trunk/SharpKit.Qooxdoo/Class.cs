// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx
{
    /// <summary>
	/// <para>This class is one of the most important parts of qooxdoo&#8217;s
	/// object-oriented features.</para>
	/// <para>Its <see cref="Define"/> method is used to create qooxdoo classes.</para>
	/// <para>Each instance of a class defined by <see cref="Define"/> has
	/// the following keys attached to the constructor and the prototype:</para>
	/// 
	/// classnameThe fully-qualified name of the class (e.g. "qx.ui.core.Widget").
	/// basenameThe namespace part of the class name (e.g. "qx.ui.core").
	/// constructorA reference to the constructor of the class.
	/// superclassA reference to the constructor of the super class.
	/// 
	/// <para>Each method may access static members of the same class by using
	/// this.self(arguments) (<see cref="qx.core.Object.Self"/>):</para>
	/// <code>
	/// statics : { FOO : "bar" },
	/// members: {
	/// baz: function(x) {
	/// this.self(arguments).FOO;
	/// ...
	/// }
	/// }
	/// </code>
	/// <para>Each overriding method may call the overridden method by using
	/// this.base(arguments [, ...]) (<see cref="qx.core.Object.Base"/>). This is also true for calling
	/// the constructor of the superclass.</para>
	/// <code>
	/// members: {
	/// foo: function(x) {
	/// this.base(arguments, x);
	/// ...
	/// }
	/// }
	/// </code>
	/// <para>By using qx.Class within an app, the native JS data types are
	/// conveniently polyfilled according to <see cref="qx.lang.normalize"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.Class", OmitOptionalParameters = true, Export = false)]
    public partial class Class 
    {
		#region Methods

		public Class() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Define a new class using the qooxdoo class system. This sets up the
		/// namespace for the class and generates the class from the definition map.</para>
		/// <para>Example:</para>
		/// <code>
		/// qx.Class.define("name",
		/// {
		/// extend : Object, // superclass
		/// implement : [Interfaces],
		/// include : [Mixins],
		/// statics:
		/// {
		/// CONSTANT : 3.141,
		/// publicMethod: function() {},
		/// _protectedMethod: function() {},
		/// __privateMethod: function() {}
		/// },
		/// properties:
		/// {
		/// "tabIndex": { check: "Number", init : -1 }
		/// },
		/// members:
		/// {
		/// publicField: "foo",
		/// publicMethod: function() {},
		/// _protectedField: "bar",
		/// _protectedMethod: function() {},
		/// __privateField: "baz",
		/// __privateMethod: function() {}
		/// }
		/// });
		/// </code>
		/// </summary>
		/// <param name="name">Name of the class. If null, the class will not be added to any namespace which could be handy for testing.</param>
		/// <param name="config">Class definition structure. The configuration map has the following keys:  NameTypeDescription typeString Type of the class. Valid types are &#8220;abstract&#8221;, &#8220;static&#8221; and &#8220;singleton&#8221;. If unset it defaults to a regular non-static class.  extendClassThe super class the current class inherits from. implementInterface | Interface[]Single interface or array of interfaces the class implements. includeMixin | Mixin[]Single mixin or array of mixins, which will be merged into the class. constructFunctionThe constructor of the class. staticsMapMap of static members of the class. propertiesMapMap of property definitions. For a description of the format of a property definition see qx.core.Property. membersMapMap of instance members of the class. environmentMapMap of environment settings for this class. For a description of the format of a setting see qx.core.Environment. eventsMap Map of events the class fires. The keys are the names of the events and the values are the corresponding event type class names.  deferFunctionFunction that is called at the end of processing the class declaration. It allows access to the declared statics, members and properties. destructFunctionThe destructor of the class. </param>
		/// <returns>The defined class</returns>
		[JsMethod(Name = "define")]
		public static Class Define(string name = null, object config = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the class or one of its super classes which contains the
		/// declaration of the given interface. Returns null if the interface is not
		/// specified anywhere.</para>
		/// </summary>
		/// <param name="clazz">class to look for the interface</param>
		/// <param name="iface">interface to look for</param>
		/// <returns>the class which directly implements the given interface</returns>
		[JsMethod(Name = "getByInterface")]
		public static Class GetByInterface(Class clazz, Interface iface) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the class or one of its superclasses which contains the
		/// declaration for the given mixin. Returns null if the mixin is not
		/// specified anywhere.</para>
		/// </summary>
		/// <param name="clazz">class to look for the mixin</param>
		/// <param name="mixin">mixin to look for</param>
		/// <returns>The class which directly includes the given mixin</returns>
		[JsMethod(Name = "getByMixin")]
		public static Class GetByMixin(Class clazz, Mixin mixin) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Find a class by its name</para>
		/// </summary>
		/// <param name="name">class name to resolve</param>
		/// <returns>the class</returns>
		[JsMethod(Name = "getByName")]
		public static Class GetByName(string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the class or one of its superclasses which contains the
		/// declaration for the given property in its class definition. Returns null
		/// if the property is not specified anywhere.</para>
		/// </summary>
		/// <param name="clazz">class to look for the property</param>
		/// <param name="name">name of the property</param>
		/// <returns>The class which includes the property</returns>
		[JsMethod(Name = "getByProperty")]
		public static Class GetByProperty(Class clazz, string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the event type of the given event. Returns null if
		/// the event does not exist.</para>
		/// </summary>
		/// <param name="clazz">class to check</param>
		/// <param name="name">name of the event</param>
		/// <returns>Event type of the given event.</returns>
		[JsMethod(Name = "getEventType")]
		public static string GetEventType(Class clazz, string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a list of all interfaces a given class has to implement.</para>
		/// </summary>
		/// <param name="clazz">class which should be inspected</param>
		/// <returns>array of interfaces this class implements</returns>
		[JsMethod(Name = "getInterfaces")]
		public static Interface GetInterfaces(Class clazz) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a list of all mixins available in a given class.</para>
		/// </summary>
		/// <param name="clazz">class which should be inspected</param>
		/// <returns>array of mixins this class uses</returns>
		[JsMethod(Name = "getMixins")]
		public static Mixin GetMixins(Class clazz) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a list of all properties supported by the given class</para>
		/// </summary>
		/// <param name="clazz">Class to query</param>
		/// <returns>List of all property names</returns>
		[JsMethod(Name = "getProperties")]
		public static string GetProperties(Class clazz) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the definition of the given property. Returns null
		/// if the property does not exist.</para>
		/// </summary>
		/// <param name="clazz">class to check</param>
		/// <param name="name">name of the class to check for</param>
		/// <returns>whether the object support the given event.</returns>
		[JsMethod(Name = "getPropertyDefinition")]
		public static object GetPropertyDefinition(Class clazz, string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Determine the total number of classes</para>
		/// </summary>
		/// <returns>the total number of classes</returns>
		[JsMethod(Name = "getTotalNumber")]
		public static double GetTotalNumber() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a given class or any of its super classes includes a given interface.</para>
		/// <para>This function will return &#8220;true&#8221; if the interface was defined
		/// in the class declaration (<see cref="qx.Class.Define"/>) of the class
		/// or any of its super classes using the &#8220;implement&#8221;
		/// key.</para>
		/// </summary>
		/// <param name="clazz">class to check</param>
		/// <param name="iface">the interface to check for</param>
		/// <returns>whether the class includes the interface.</returns>
		[JsMethod(Name = "hasInterface")]
		public static bool HasInterface(Class clazz, Interface iface) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a given class or any of its superclasses includes a given mixin.</para>
		/// </summary>
		/// <param name="clazz">class to check</param>
		/// <param name="mixin">the mixin to check for</param>
		/// <returns>whether the class includes the mixin.</returns>
		[JsMethod(Name = "hasMixin")]
		public static bool HasMixin(Class clazz, Mixin mixin) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a given class directly includes an interface.</para>
		/// <para>This function will only return &#8220;true&#8221; if the interface was defined
		/// in the class declaration (<see cref="qx.Class.Define"/>) using the &#8220;implement&#8221;
		/// key.</para>
		/// </summary>
		/// <param name="clazz">class or instance to check</param>
		/// <param name="iface">the interface to check for</param>
		/// <returns>whether the class includes the mixin directly.</returns>
		[JsMethod(Name = "hasOwnInterface")]
		public static bool HasOwnInterface(Class clazz, Interface iface) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a class directly includes a mixin.</para>
		/// </summary>
		/// <param name="clazz">class to check</param>
		/// <param name="mixin">the mixin to check for</param>
		/// <returns>whether the class includes the mixin directly.</returns>
		[JsMethod(Name = "hasOwnMixin")]
		public static bool HasOwnMixin(Class clazz, Mixin mixin) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a class has the given property</para>
		/// </summary>
		/// <param name="clazz">class to check</param>
		/// <param name="name">name of the property to check for</param>
		/// <returns>whether the class includes the given property.</returns>
		[JsMethod(Name = "hasProperty")]
		public static bool HasProperty(Class clazz, string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a given class to an interface.</para>
		/// <para>Checks whether all methods defined in the interface are
		/// implemented. The class does not need to implement
		/// the interface explicitly in the extend key.</para>
		/// </summary>
		/// <param name="obj">class to check</param>
		/// <param name="iface">the interface to check for</param>
		/// <returns>whether the class conforms to the interface.</returns>
		[JsMethod(Name = "implementsInterface")]
		public static bool ImplementsInterface(object obj, Interface iface) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Include all features of the given mixin into the class. The mixin must
		/// not include any methods or properties that are already available in the
		/// class. This would only be possible using the <see cref="Patch"/> method.</para>
		/// </summary>
		/// <param name="clazz">An existing class which should be augmented by including a mixin.</param>
		/// <param name="mixin">The mixin to be included.</param>
		[JsMethod(Name = "include")]
		public static void Include(Class clazz, Mixin mixin) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the given class exists</para>
		/// </summary>
		/// <param name="name">class name to check</param>
		/// <returns>true if class exists</returns>
		[JsMethod(Name = "isDefined")]
		public static bool IsDefined(string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a class is a direct or indirect sub class of another class,
		/// or both classes coincide.</para>
		/// </summary>
		/// <param name="clazz">the class to check.</param>
		/// <param name="superClass">the potential super class</param>
		/// <returns>whether clazz is a sub class of superClass.</returns>
		[JsMethod(Name = "isSubClassOf")]
		public static bool IsSubClassOf(Class clazz, Class superClass) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Include all features of the given mixin into the class. The mixin may
		/// include features, which are already defined in the target class. Existing
		/// features of equal name will be overwritten.
		/// Please keep in mind that this functionality is not intended for regular
		/// use, but as a formalized way (and a last resort) in order to patch
		/// existing classes.</para>
		/// WARNING: You may break working classes and features.
		/// </summary>
		/// <param name="clazz">An existing class which should be modified by including a mixin.</param>
		/// <param name="mixin">The mixin to be included.</param>
		[JsMethod(Name = "patch")]
		public static void Patch(Class clazz, Mixin mixin) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a class supports the given event type</para>
		/// </summary>
		/// <param name="clazz">class to check</param>
		/// <param name="name">name of the event to check for</param>
		/// <returns>whether the class supports the given event.</returns>
		[JsMethod(Name = "supportsEvent")]
		public static bool SupportsEvent(Class clazz, string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes a class from qooxdoo defined by <see cref="Define"/></para>
		/// </summary>
		/// <param name="name">Name of the class</param>
		[JsMethod(Name = "undefine")]
		public static void Undefine(string name) { throw new NotImplementedException(); }

		#endregion Methods
    }
}