//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region FieldAncestor
    /// <summary>
    /// A mixin for Ext.container.Container components that are likely to have form fields in their
    /// items subtree. Adds the following capabilities:  Methods for handling the addition and removal of Ext.form.Labelable and Ext.form.field.Field
    /// instances at any depth within the container. Events (fieldvaliditychange and fielderrorchange) for handling changes to the state
    /// of individual fields at the container level. Automatic application of fieldDefaults config properties to each field added within the
    /// container, to facilitate uniform configuration of all fields.  This mixin is primarily for internal use by Ext.form.Panel and Ext.form.FieldContainer,
    /// and should not normally need to be used directly.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial interface FieldAncestor
    {
        /// <summary>
        /// Initializes the FieldAncestor's state; this must be called from the initComponent method
        /// of any components importing ...
        /// </summary>
        object initFieldAncestor();
        /// <summary>
        /// Called when a Ext.form.field.Field instance is added to the container's subtree. ...
        /// </summary>
        object onFieldAdded(Ext.form.field.Field field);
        /// <summary>
        /// Called when a Ext.form.field.Field instance is removed from the container's subtree. ...
        /// </summary>
        object onFieldRemoved(Ext.form.field.Field field);
        /// <summary>
        /// Called when a Ext.form.Labelable instance is added to the container's subtree. ...
        /// </summary>
        object onLabelableAdded(Labelable labelable);
        /// <summary>
        /// Called when a Ext.form.Labelable instance is removed from the container's subtree. ...
        /// </summary>
        object onLabelableRemoved(Labelable labelable);
        object onFieldErrorChange{get;set;}
        object onFieldValidityChange{get;set;}
    }
    #endregion
    #region FieldAncestorConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class FieldAncestorConfig : Ext.BaseConfig
    {
        /// <summary>
        /// If specified, the properties in this object are used as default config values for each
        /// Ext.form.Labelable instance (e.g. ...
        /// </summary>
        public object fieldDefaults{get;set;}
    }
    #endregion
    #region FieldAncestorEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class FieldAncestorEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when the active error message is changed for any one of the Ext.form.Labelable
        /// instances within this container. ...
        /// </summary>
        public static JsString fielderrorchange="fielderrorchange";
    }
    #endregion
}
#endregion