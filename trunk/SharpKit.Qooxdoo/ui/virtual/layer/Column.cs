// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.layer
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>The Row layer renders row background colors.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.layer.Column", OmitOptionalParameters = true, Export = false)]
    public partial class Column : qx.ui.virtualx.layer.AbstractBackground
    {
		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		#endregion Properties

		#region Methods

		public Column() { throw new NotImplementedException(); }

		[JsMethod(Name = "setColor")]
		public void SetColor(object index, object color) { throw new NotImplementedException(); }

		[JsMethod(Name = "updateLayerWindow")]
		public void UpdateLayerWindow(object firstRow, object firstColumn, object rowSizes, object columnSizes) { throw new NotImplementedException(); }

		#endregion Methods
    }
}