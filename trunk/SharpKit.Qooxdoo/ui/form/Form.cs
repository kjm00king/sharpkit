// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>The form object is responsible for managing form items. For that, it takes
	/// advantage of two existing qooxdoo classes.
	/// The <see cref="qx.ui.form.Resetter"/> is used for resetting and the
	/// <see cref="qx.ui.form.validation.Manager"/> is used for all validation purposes.</para>
	/// <para>The view code can be found in the used renderer (<see cref="qx.ui.form.renderer"/>).</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.Form", OmitOptionalParameters = true, Export = false)]
    public partial class Form : qx.core.Object
    {
		#region Methods

		public Form() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a form item to the form including its internal
		/// <see cref="qx.ui.form.validation.Manager"/> and <see cref="qx.ui.form.Resetter"/>.</para>
		/// <para>Hint: The order of all add calls represent the order in the layout.</para>
		/// </summary>
		/// <param name="item">A supported form item.</param>
		/// <param name="label">The string, which should be used as label.</param>
		/// <param name="validator">The validator which is used by the validation qx.ui.form.validation.Manager.</param>
		/// <param name="name">The name which is used by the data binding controller qx.data.controller.Form.</param>
		/// <param name="validatorContext">The context of the validator.</param>
		/// <param name="options">An additional map containin custom data which will be available in your form renderer specific to the added item.</param>
		[JsMethod(Name = "add")]
		public void Add(qx.ui.form.IForm item, string label, object validator = null, string name = null, object validatorContext = null, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a button to the form.</para>
		/// <para>Hint: The order of all add calls represent the order in the layout.</para>
		/// </summary>
		/// <param name="button">The button to add.</param>
		/// <param name="options">An additional map containin custom data which will be available in your form renderer specific to the added button.</param>
		[JsMethod(Name = "addButton")]
		public void AddButton(qx.ui.form.Button button, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a group header to the form.</para>
		/// <para>Hint: The order of all add calls represent the order in the layout.</para>
		/// </summary>
		/// <param name="title">The title of the group header.</param>
		/// <param name="options">A special set of custom data which will be given to the renderer.</param>
		[JsMethod(Name = "addGroupHeader")]
		public void AddGroupHeader(string title, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the internally used validation manager. If you want to do some
		/// enhanced validation tasks, you need to use the validation manager.</para>
		/// </summary>
		/// <returns>The used manager.</returns>
		[JsMethod(Name = "getValidationManager")]
		public qx.ui.form.validation.Manager GetValidationManager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Redefines the values used for resetting. It calls
		/// <see cref="qx.ui.form.Resetter.Redefine"/> to get that.</para>
		/// </summary>
		[JsMethod(Name = "redefineResetter")]
		public void RedefineResetter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Redefines the value used for resetting of the given item. It calls
		/// <see cref="qx.ui.form.Resetter.RedefineItem"/> to get that.</para>
		/// </summary>
		/// <param name="item">The item to redefine.</param>
		[JsMethod(Name = "redefineResetterItem")]
		public void RedefineResetterItem(qx.ui.core.Widget item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the form. This means reseting all form items and the validation.</para>
		/// </summary>
		[JsMethod(Name = "reset")]
		public void Reset() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Validates the form using the
		/// <see cref="qx.ui.form.validation.Manager.Validate"/> method.</para>
		/// </summary>
		/// <returns>The validation result.</returns>
		[JsMethod(Name = "validate")]
		public bool Validate() { throw new NotImplementedException(); }

		#endregion Methods
    }
}