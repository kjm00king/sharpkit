// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.core
{
    /// <summary>
	/// <para>This class blocks events and can be included into all widgets.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.core.Blocker", OmitOptionalParameters = true, Export = false)]
    public partial class Blocker : qx.ui.mobile.core.Widget
    {
		#region Properties

		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public object DefaultCssClass { get; set; }

		#endregion Properties

		#region Methods

		public Blocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Force the blocker to hide, even when the show counter is larger than
		/// zero.</para>
		/// </summary>
		[JsMethod(Name = "forceHide")]
		public void ForceHide() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Hides the blocker. The blocker is only hidden when the hide method
		/// is called as many times as the <see cref="Show"/> method.</para>
		/// </summary>
		[JsMethod(Name = "hide")]
		public void Hide() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the blocker is shown or not.</para>
		/// </summary>
		/// <returns>true if the blocker is shown</returns>
		[JsMethod(Name = "isShown")]
		public bool IsShown() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Shows the blocker. When the show method is called a counter is incremented.
		/// The <see cref="Hide"/> method needs to be called as many times as the <see cref="Show"/>
		/// method. This behavior is useful, when you want to show a loading indicator.</para>
		/// </summary>
		[JsMethod(Name = "show")]
		public void Show() { throw new NotImplementedException(); }

		#endregion Methods
    }
}