// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.menu
{
    /// <summary>
	/// <para>Renders a special checkbox button inside a menu. The button behaves like
	/// a normal <see cref="qx.ui.form.CheckBox"/> and shows a check icon when
	/// checked; normally shows no icon when not checked (depends on the theme).</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.menu.CheckBox", OmitOptionalParameters = true, Export = false)]
    public partial class CheckBox : qx.ui.menu.AbstractButton, qx.ui.form.IBooleanForm
    {
		#region Events

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeValueEvent;

		#endregion Events

		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>Whether the button is checked</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "value", NativeField = true)]
		public bool Value { get; set; }

		#endregion Properties

		#region Methods

		public CheckBox() { throw new NotImplementedException(); }

		/// <param name="label">Initial label</param>
		/// <param name="menu">Initial sub menu</param>
		public CheckBox(string label, qx.ui.menu.Menu menu) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public bool GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property value
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property value.</param>
		[JsMethod(Name = "initValue")]
		public void InitValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property value equals true.</para>
		/// </summary>
		[JsMethod(Name = "isValue")]
		public void IsValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property value.</para>
		/// </summary>
		[JsMethod(Name = "toggleValue")]
		public void ToggleValue() { throw new NotImplementedException(); }

		#endregion Methods
    }
}