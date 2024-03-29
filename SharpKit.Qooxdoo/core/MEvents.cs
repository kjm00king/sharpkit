// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.core
{
    /// <summary>
	/// <para>This mixin offers basic event handling capabilities. It includes the
	/// commonly known methods for managing event listeners and firing events.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.core.MEvents", OmitOptionalParameters = true, Export = false)]
    public partial class MEvents 
    {
		#region Methods

		public MEvents() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add event listener to this object.</para>
		/// </summary>
		/// <param name="type">name of the event type</param>
		/// <param name="listener">event callback function</param>
		/// <param name="self">Reference to the &#8216;this&#8217; variable inside the event listener. When not given, the corresponding dispatcher usually falls back to a default, which is the target by convention. Note this is not a strict requirement, i.e. custom dispatchers can follow a different strategy.</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event. The default is to attach the event handler to the bubbling phase.</param>
		/// <returns>An opaque id, which can be used to remove the event listener using the #removeListenerById method.</returns>
		[JsMethod(Name = "addListener")]
		public string AddListener(string type, Action<qx.eventx.type.Data> listener, object self = null, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add event listener to this object, which is only called once. After the
		/// listener is called the event listener gets removed.</para>
		/// </summary>
		/// <param name="type">name of the event type</param>
		/// <param name="listener">event callback function</param>
		/// <param name="self">reference to the &#8216;this&#8217; variable inside the callback</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event. The default is to attach the event handler to the bubbling phase.</param>
		/// <returns>An opaque id, which can be used to remove the event listener using the #removeListenerById method.</returns>
		[JsMethod(Name = "addListenerOnce")]
		public string AddListenerOnce(string type, Action<qx.eventx.type.Data> listener, object self = null, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Dispatch an event on this object</para>
		/// </summary>
		/// <param name="evt">event to dispatch</param>
		/// <returns>Whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "dispatchEvent")]
		public bool DispatchEvent(qx.eventx.type.Event evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates and dispatches an non-bubbling data event on this object.</para>
		/// </summary>
		/// <param name="type">Event type to fire</param>
		/// <param name="data">User defined data attached to the event object</param>
		/// <param name="oldData">The event&#8217;s old data (optional)</param>
		/// <param name="cancelable">Whether or not an event can have its default action prevented. The default action can either be the browser&#8217;s default action of a native event (e.g. open the context menu on a right click) or the default action of a qooxdoo class (e.g. close the window widget). The default action can be prevented by calling qx.event.type.Event#preventDefault</param>
		/// <returns>Whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "fireDataEvent")]
		public bool FireDataEvent(string type, object data, object oldData = null, bool cancelable = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates and dispatches an event on this object.</para>
		/// </summary>
		/// <param name="type">Event type to fire</param>
		/// <param name="clazz">The event class</param>
		/// <param name="args">Arguments, which will be passed to the event&#8217;s init method.</param>
		/// <returns>Whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "fireEvent")]
		public bool FireEvent(string type, Class clazz = null, JsArray args = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create an event object and dispatch it on this object.
		/// The event dispatched with this method does never bubble! Use only if you
		/// are sure that bubbling is not required.</para>
		/// </summary>
		/// <param name="type">Event type to fire</param>
		/// <param name="clazz">The event class</param>
		/// <param name="args">Arguments, which will be passed to the event&#8217;s init method.</param>
		/// <returns>Whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "fireNonBubblingEvent")]
		public bool FireNonBubblingEvent(string type, Class clazz = null, JsArray args = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check if there are one or more listeners for an event type.</para>
		/// </summary>
		/// <param name="type">name of the event type</param>
		/// <param name="capture">Whether to check for listeners of the bubbling or of the capturing phase.</param>
		/// <returns>Whether the object has a listener of the given type.</returns>
		[JsMethod(Name = "hasListener")]
		public bool HasListener(string type, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove event listener from this object</para>
		/// </summary>
		/// <param name="type">name of the event type</param>
		/// <param name="listener">event callback function</param>
		/// <param name="self">reference to the &#8216;this&#8217; variable inside the callback</param>
		/// <param name="capture">Whether to remove the event listener of the bubbling or of the capturing phase.</param>
		/// <returns>Whether the event was removed successfully (has existed)</returns>
		[JsMethod(Name = "removeListener")]
		public bool RemoveListener(string type, Action<qx.eventx.type.Data> listener, object self = null, bool? capture = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes an event listener from an event target by an id returned by
		/// <see cref="AddListener"/></para>
		/// </summary>
		/// <param name="id">The id returned by #addListener</param>
		/// <returns>Whether the event was removed successfully (has existed)</returns>
		[JsMethod(Name = "removeListenerById")]
		public bool RemoveListenerById(string id) { throw new NotImplementedException(); }

		#endregion Methods
    }
}