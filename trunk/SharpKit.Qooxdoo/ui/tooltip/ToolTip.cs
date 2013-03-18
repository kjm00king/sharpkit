// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.tooltip
{
    /// <summary>
	/// <para>A Tooltip provides additional information for widgets when the user hovers
	/// over a widget.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.tooltip.ToolTip", OmitOptionalParameters = true, Export = false)]
    public partial class ToolTip : qx.ui.popup.Popup
    {
		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Interval after the tooltip is hidden (in milliseconds)</para>
		/// </summary>
		[JsProperty(Name = "hideTimeout", NativeField = true)]
		public double HideTimeout { get; set; }

		/// <summary>
		/// <para>Any URI String supported by qx.ui.basic.Image to display an icon in
		/// ToolTips&#8217;s atom.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "icon", NativeField = true)]
		public string Icon { get; set; }

		/// <summary>
		/// <para>The label/caption/text of the ToolTip&#8217;s atom.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "label", NativeField = true)]
		public string Label { get; set; }

		/// <summary>
		/// <para>Widget that opened the tooltip</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "opener", NativeField = true)]
		public qx.ui.core.Widget Opener { get; set; }

		/// <summary>
		/// <para>Switches between rich HTML and text content. The text mode
		/// (false) supports advanced features like ellipsis when the
		/// available space is not enough. HTML mode (true) supports
		/// multi-line content and all the markup features of HTML content.</para>
		/// </summary>
		[JsProperty(Name = "rich", NativeField = true)]
		public bool Rich { get; set; }

		/// <summary>
		/// <para>Interval after the tooltip is shown (in milliseconds)</para>
		/// </summary>
		[JsProperty(Name = "showTimeout", NativeField = true)]
		public double ShowTimeout { get; set; }

		#endregion Properties

		#region Methods

		public ToolTip() { throw new NotImplementedException(); }

		/// <param name="label">label of the tooltip</param>
		/// <param name="icon">Icon URL of the tooltip</param>
		public ToolTip(string label, string icon = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property hideTimeout.</para>
		/// </summary>
		[JsMethod(Name = "getHideTimeout")]
		public double GetHideTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property icon.</para>
		/// </summary>
		[JsMethod(Name = "getIcon")]
		public string GetIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property label.</para>
		/// </summary>
		[JsMethod(Name = "getLabel")]
		public string GetLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property opener.</para>
		/// </summary>
		[JsMethod(Name = "getOpener")]
		public qx.ui.core.Widget GetOpener() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property rich.</para>
		/// </summary>
		[JsMethod(Name = "getRich")]
		public bool GetRich() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showTimeout.</para>
		/// </summary>
		[JsMethod(Name = "getShowTimeout")]
		public double GetShowTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property hideTimeout
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property hideTimeout.</param>
		[JsMethod(Name = "initHideTimeout")]
		public void InitHideTimeout(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property icon
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property icon.</param>
		[JsMethod(Name = "initIcon")]
		public void InitIcon(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property label
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property label.</param>
		[JsMethod(Name = "initLabel")]
		public void InitLabel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property opener
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property opener.</param>
		[JsMethod(Name = "initOpener")]
		public void InitOpener(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property rich
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property rich.</param>
		[JsMethod(Name = "initRich")]
		public void InitRich(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showTimeout
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showTimeout.</param>
		[JsMethod(Name = "initShowTimeout")]
		public void InitShowTimeout(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property rich equals true.</para>
		/// </summary>
		[JsMethod(Name = "isRich")]
		public void IsRich() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property hideTimeout.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetHideTimeout")]
		public void ResetHideTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property icon.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIcon")]
		public void ResetIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property label.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabel")]
		public void ResetLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property opener.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOpener")]
		public void ResetOpener() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property rich.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRich")]
		public void ResetRich() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showTimeout.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowTimeout")]
		public void ResetShowTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property hideTimeout.</para>
		/// </summary>
		/// <param name="value">New value for property hideTimeout.</param>
		[JsMethod(Name = "setHideTimeout")]
		public void SetHideTimeout(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property icon.</para>
		/// </summary>
		/// <param name="value">New value for property icon.</param>
		[JsMethod(Name = "setIcon")]
		public void SetIcon(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property label.</para>
		/// </summary>
		/// <param name="value">New value for property label.</param>
		[JsMethod(Name = "setLabel")]
		public void SetLabel(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property opener.</para>
		/// </summary>
		/// <param name="value">New value for property opener.</param>
		[JsMethod(Name = "setOpener")]
		public void SetOpener(qx.ui.core.Widget value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property rich.</para>
		/// </summary>
		/// <param name="value">New value for property rich.</param>
		[JsMethod(Name = "setRich")]
		public void SetRich(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showTimeout.</para>
		/// </summary>
		/// <param name="value">New value for property showTimeout.</param>
		[JsMethod(Name = "setShowTimeout")]
		public void SetShowTimeout(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property rich.</para>
		/// </summary>
		[JsMethod(Name = "toggleRich")]
		public void ToggleRich() { throw new NotImplementedException(); }

		#endregion Methods
    }
}