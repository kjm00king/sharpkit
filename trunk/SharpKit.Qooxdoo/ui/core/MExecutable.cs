// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>This mixin is included by all widgets, which support an &#8216;execute&#8217; like
	/// buttons or menu entries.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.MExecutable", OmitOptionalParameters = true, Export = false)]
    public partial class MExecutable 
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Command"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeCommandEvent;

		/// <summary>
		/// <para>Fired if the <see cref="Execute"/> method is invoked.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> ExecuteEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>A command called if the <see cref="Execute"/> method is called, e.g. on a
		/// button click.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "command", NativeField = true)]
		public qx.ui.core.Command Command { get; set; }

		#endregion Properties

		#region Methods

		public MExecutable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Initiate the execute action.</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property command.</para>
		/// </summary>
		[JsMethod(Name = "getCommand")]
		public qx.ui.core.Command GetCommand() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property command
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property command.</param>
		[JsMethod(Name = "initCommand")]
		public void InitCommand(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property command.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCommand")]
		public void ResetCommand() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property command.</para>
		/// </summary>
		/// <param name="value">New value for property command.</param>
		[JsMethod(Name = "setCommand")]
		public void SetCommand(qx.ui.core.Command value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}