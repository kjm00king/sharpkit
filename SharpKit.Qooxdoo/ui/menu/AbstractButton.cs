// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.menu
{
    /// <summary>
	/// <para>The abstract menu button class is used for all type of menu content
	/// for example normal buttons, checkboxes or radiobuttons.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.menu.AbstractButton", OmitOptionalParameters = true, Export = false)]
    public abstract partial class AbstractButton : qx.ui.core.Widget, qx.ui.form.IExecutable
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Icon"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeIcon;

		/// <summary>
		/// Fired on change of the property <see cref="Label"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeLabel;

		/// <summary>
		/// Fired on change of the property <see cref="Menu"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeMenu;

		/// <summary>
		/// Fired on change of the property <see cref="ShowCommandLabel"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeShowCommandLabel;

		/// <summary>
		/// Fired on change of the property <see cref="Command"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeCommand;

		/// <summary>
		/// <para>Fired when the widget is executed. Sets the &#8220;data&#8221; property of the
		/// event to the object that issued the command.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnExecute;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Controls if a tooltip should shown or not.</para>
		/// </summary>
		[JsProperty(Name = "blockToolTip", NativeField = true)]
		public bool BlockToolTip { get; set; }

		/// <summary>
		/// <para>The icon to use</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "icon", NativeField = true)]
		public string Icon { get; set; }

		/// <summary>
		/// <para>The label text of the button</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "label", NativeField = true)]
		public string Label { get; set; }

		/// <summary>
		/// <para>Whether a sub menu should be shown and which one</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "menu", NativeField = true)]
		public qx.ui.menu.Menu Menu { get; set; }

		/// <summary>
		/// <para>Indicates whether the label for the command (shortcut) should be visible or not.</para>
		/// </summary>
		[JsProperty(Name = "showCommandLabel", NativeField = true)]
		public bool ShowCommandLabel { get; set; }

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

		public AbstractButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the dimensions of all children</para>
		/// </summary>
		/// <returns>Preferred width of each child</returns>
		[JsMethod(Name = "getChildrenSizes")]
		public JsArray GetChildrenSizes() { throw new NotImplementedException(); }

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
		/// <para>Returns the (computed) value of the property menu.</para>
		/// </summary>
		[JsMethod(Name = "getMenu")]
		public qx.ui.menu.Menu GetMenu() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showCommandLabel.</para>
		/// </summary>
		[JsMethod(Name = "getShowCommandLabel")]
		public bool GetShowCommandLabel() { throw new NotImplementedException(); }

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
		/// <para>Calls the apply method and dispatches the change event of the property menu
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property menu.</param>
		[JsMethod(Name = "initMenu")]
		public void InitMenu(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showCommandLabel
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showCommandLabel.</param>
		[JsMethod(Name = "initShowCommandLabel")]
		public void InitShowCommandLabel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showCommandLabel equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowCommandLabel")]
		public void IsShowCommandLabel() { throw new NotImplementedException(); }

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
		/// <para>Resets the user value of the property menu.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMenu")]
		public void ResetMenu() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showCommandLabel.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowCommandLabel")]
		public void ResetShowCommandLabel() { throw new NotImplementedException(); }

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
		/// <para>Sets the user value of the property menu.</para>
		/// </summary>
		/// <param name="value">New value for property menu.</param>
		[JsMethod(Name = "setMenu")]
		public void SetMenu(qx.ui.menu.Menu value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showCommandLabel.</para>
		/// </summary>
		/// <param name="value">New value for property showCommandLabel.</param>
		[JsMethod(Name = "setShowCommandLabel")]
		public void SetShowCommandLabel(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showCommandLabel.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowCommandLabel")]
		public void ToggleShowCommandLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Fire the &#8220;execute&#8221; event on the command.</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current set command of this executable.</para>
		/// </summary>
		/// <returns>The current set command.</returns>
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
		/// <para>Set the command of this executable.</para>
		/// </summary>
		/// <param name="command">The command.</param>
		[JsMethod(Name = "setCommand")]
		public void SetCommand(qx.ui.core.Command command) { throw new NotImplementedException(); }

		#endregion Methods
    }
}