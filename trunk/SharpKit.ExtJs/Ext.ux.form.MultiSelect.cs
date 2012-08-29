//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux.form
{
    #region MultiSelect
    /// <inheritdocs />
    /// <summary>
    /// <p>A control that allows selection of multiple items in a list</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class MultiSelect : Ext.form.FieldContainer, Ext.util.Bindable, Ext.form.field.Field
    {
        /// <summary>
        /// False to require at least one item in the list to be selected, true to allow no
        /// selection.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowBlank;
        /// <summary>
        /// True if the list should only allow append drops when drag/drop is enabled.
        /// This is useful for lists which are sorted.
        /// Defaults to: <c>false</c>
        /// </summary>
        public JsString appendOnly;
        /// <summary>
        /// Default text displayed when the control contains no items.
        /// Defaults to: <c>&quot;This field is required&quot;</c>
        /// </summary>
        public JsString blankText;
        /// <summary>
        /// Whether the items in the MultiSelect list are drag/drop reorderable.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool ddReorder;
        /// <summary>
        /// The string used to delimit the selected values when submitting
        /// the field as part of a form. If you wish to have the selected values submitted as separate
        /// parameters rather than a single delimited parameter, set this to null.
        /// Defaults to: <c>&quot;,&quot;</c>
        /// </summary>
        public JsString delimiter;
        /// <summary>
        /// Name of the desired display field in the dataset.
        /// Defaults to: <c>&quot;text&quot;</c>
        /// </summary>
        public JsString displayField;
        /// <summary>
        /// The ddgroup name for the MultiSelect DragZone.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString dragGroup;
        /// <summary>
        /// The ddgroup name for the MultiSelect DropZone.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString dropGroup;
        /// <summary>
        /// An optional set of configuration properties that will be passed to the Ext.view.BoundList's constructor.
        /// Any configuration that is valid for BoundList can be included.
        /// </summary>
        public JsObject listConfig;
        /// <summary>
        /// Maximum number of selections allowed.
        /// Defaults to: <c>Number.MAX_VALUE</c>
        /// </summary>
        public JsNumber maxSelections;
        /// <summary>
        /// Validation message displayed when maxSelections is not met
        /// The {0} token will be replaced by the value of maxSelections.
        /// Defaults to: <c>&quot;Maximum {0}item(s) allowed&quot;</c>
        /// </summary>
        public JsString maxSelectionsText;
        /// <summary>
        /// Minimum number of selections allowed.
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber minSelections;
        /// <summary>
        /// Validation message displayed when minSelections is not met.
        /// The {0} token will be replaced by the value of minSelections.
        /// Defaults to: <c>&quot;Minimum {0}item(s) required&quot;</c>
        /// </summary>
        public JsString minSelectionsText;
        /// <summary>
        /// The name of the field. By default this is used as the parameter name when including the
        /// field value in a form submit(). To prevent the field from
        /// being included in the form submit, set submitValue to false.
        /// </summary>
        public JsString name;
        /// <summary>
        /// The data source to which this MultiSelect is bound (defaults to undefined).
        /// Acceptable values for this property are:
        /// <ul>
        /// <li><b>any <see cref="Ext.data.Store">Store</see> subclass</b></li>
        /// <li><b>an Array</b> : Arrays will be converted to a <see cref="Ext.data.ArrayStore">Ext.data.ArrayStore</see> internally.
        /// <div><ul>
        /// <li><b>1-dimensional array</b> : (e.g., <tt>['Foo','Bar']</tt>)<div>
        /// A 1-dimensional array will automatically be expanded (each array item will be the combo
        /// <see cref="Ext.ux.form.MultiSelectConfig.valueField">value</see> and <see cref="Ext.ux.form.MultiSelectConfig.displayField">text</see>)</div></li>
        /// <li><b>2-dimensional array</b> : (e.g., <tt>[['f','Foo'],['b','Bar']]</tt>)<div>
        /// For a multi-dimensional array, the value in index 0 of each item will be assumed to be the combo
        /// <see cref="Ext.ux.form.MultiSelectConfig.valueField">value</see>, while the value at index 1 is assumed to be the combo <see cref="Ext.ux.form.MultiSelectConfig.displayField">text</see>.
        /// </div></li></ul></div></li></ul>
        /// </summary>
        public object store;
        /// <summary>
        /// Setting this to false will prevent the field from being submitted even when it is
        /// not disabled.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitValue;
        /// <summary>
        /// An optional toolbar to be inserted at the top of the control's selection list.
        /// This can be a Ext.toolbar.Toolbar object, a toolbar config, or an array of buttons/button configs
        /// to be added to the toolbar. See Ext.panel.Panel.tbar.
        /// </summary>
        public object tbar;
        /// <summary>
        /// A title for the underlying panel.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString title;
        /// <summary>
        /// Specifies whether this field should be validated immediately whenever a change in its value is detected.
        /// If the validation results in a change in the field's validity, a validitychange event will be
        /// fired. This allows the field to show feedback about the validity of its contents immediately as the user is
        /// typing.
        /// When set to false, feedback will not be immediate. However the form will still be validated before submitting if
        /// the clientValidation option to <see cref="Ext.form.Basic.doAction">Ext.form.Basic.doAction</see> is enabled, or if the field or form are validated
        /// manually.
        /// See also <see cref="Ext.form.field.BaseConfig.checkChangeEvents">Ext.form.field.Base.checkChangeEvents</see> for controlling how changes to the field's value are
        /// detected.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool validateOnChange;
        /// <summary>
        /// A value to initialize this field with.
        /// </summary>
        public JsObject value;
        /// <summary>
        /// Name of the desired value field in the dataset.
        /// Defaults to: <c>&quot;text&quot;</c>
        /// </summary>
        public JsString valueField;
        /// <summary>
        /// Flag denoting that this component is a Field. Always true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isFormField{get;set;}
        /// <summary>
        /// The original value of the field as configured in the value configuration, or as loaded by the last
        /// form load operation if the form's trackResetOnLoad setting is true.
        /// </summary>
        public JsObject originalValue{get;set;}
        /// <summary>
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber suspendCheckChange{get;set;}
        /// <summary>
        /// A utility for grouping a set of modifications which may trigger value changes into a single transaction, to
        /// prevent excessive firing of change events. This is useful for instance if the field has sub-fields which
        /// are being updated as a group; you don't want the container field to check its own changed state for each subfield
        /// change.
        /// </summary>
        /// <param name="fn"><p>A function containing the transaction code</p>
        /// </param>
        public virtual void batchChanges(System.Delegate fn){}
        /// <summary>
        /// Template method before a field is reset.
        /// </summary>
        public virtual void beforeReset(){}
        /// <summary>
        /// Binds a store to this instance.
        /// </summary>
        /// <param name="store"><p>The store to bind or ID of the store.
        /// When no store given (or when <c>null</c> or <c>undefined</c> passed), unbinds the existing store.</p>
        /// </param>
        /// <param name="initial"><p>True to not remove listeners from existing store.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        public virtual void bindStore(object store=null, object initial=null){}
        /// <summary>
        /// Binds listeners for this component to the store. By default it will add
        /// anything bound by the getStoreListeners method, however it can be overridden
        /// in a subclass to provide any more complicated handling.
        /// </summary>
        /// <param name="store"><p>The store to bind to</p>
        /// </param>
        public virtual void bindStoreListeners(Ext.data.AbstractStore store){}
        /// <summary>
        /// Checks whether the value of the field has changed since the last time it was checked.
        /// If the value has changed, it:
        /// <li>Fires the <see cref="Ext.form.field.FieldEvents.change">change event</see>,</li>
        /// <li>Performs validation if the <see cref="Ext.form.field.FieldConfig.validateOnChange">validateOnChange</see> config is enabled, firing the
        /// <see cref="Ext.form.field.FieldEvents.validitychange">validitychange event</see> if the validity has changed, and</li>
        /// <li>Checks the <see cref="Ext.form.field.Field.isDirty">dirty state</see> of the field and fires the <see cref="Ext.form.field.FieldEvents.dirtychange">dirtychange event</see>
        /// if it has changed.</li>
        /// </summary>
        public virtual void checkChange(){}
        /// <summary>
        /// Checks the isDirty state of the field and if it has changed since the last time it was checked,
        /// fires the dirtychange event.
        /// </summary>
        public virtual void checkDirty(){}
        /// <summary>
        /// Clear any invalid styles/messages for this field.
        /// <strong>Note</strong>: this method does not cause the Field's <see cref="Ext.ux.form.MultiSelect.validate">validate</see> or <see cref="Ext.ux.form.MultiSelect.isValid">isValid</see> methods to return <c>true</c>
        /// if the value does not <em>pass</em> validation. So simply clearing a field's errors will not necessarily allow
        /// submission of forms submitted with the <see cref="Ext.form.action.SubmitConfig.clientValidation">Ext.form.action.Submit.clientValidation</see> option set.
        /// Overrides: <see cref="Ext.form.field.Field.clearInvalid">Ext.form.field.Field.clearInvalid</see>
        /// </summary>
        public virtual void clearInvalid(){}
        /// <summary>
        /// Only relevant if the instance's isFileUpload method returns true. Returns a reference to the file input
        /// DOM element holding the user's selected file. The input will be appended into the submission form and will not be
        /// returned, so this method should also create a replacement.
        /// </summary>
        /// <returns>
        /// <span>HTMLElement</span><div>
        /// </div>
        /// </returns>
        public virtual JsObject extractFileInput(){return null;}
        /// <summary>
        /// Runs this field's validators and returns an array of error messages for any validation failures. This is called
        /// internally during validation and would not usually need to be used manually.
        /// Each subclass should override or augment the return value to provide their own errors.
        /// </summary>
        /// <param name="value"><p>The value to get errors for (defaults to the current field value)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see>[]</span><div><p>All error messages for this field; an empty Array if none.</p>
        /// </div>
        /// </returns>
        public virtual JsString[] getErrors(object value=null){return null;}
        /// <summary>
        /// Returns the value(s) that should be saved to the Ext.data.Model instance for this field, when Ext.form.Basic.updateRecord is called. Typically this will be an object with a single name-value pair, the name
        /// being this field's name and the value being its current data value. More advanced field
        /// implementations may return more than one name-value pair. The returned values will be saved to the corresponding
        /// field names in the Model.
        /// Note that the values returned from this method are not guaranteed to have been successfully <see cref="Ext.form.field.Field.validate">validated</see>.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>A mapping of submit parameter names to values; each value should be a string, or an array of
        /// strings if that particular name has multiple values. It can also return null if there are no parameters to be
        /// submitted.</p>
        /// </div>
        /// </returns>
        public virtual object getModelData(){return null;}
        /// <summary>
        /// Returns the name attribute of the field. This is used as the parameter name
        /// when including the field value in a form submit().
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>name The field <see cref="Ext.form.field.FieldConfig.name">name</see></p>
        /// </div>
        /// </returns>
        public virtual JsString getName(){return null;}
        /// <summary>
        /// Gets the current store instance.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.data.AbstractStore">Ext.data.AbstractStore</see></span><div><p>The store, null if one does not exist.</p>
        /// </div>
        /// </returns>
        public virtual Ext.data.Store getStore(){return null;}
        /// <summary>
        /// Gets the listeners to bind to a new store.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The listeners to be bound to the store in object literal form. The scope
        /// may be omitted, it is assumed to be the current instance.</p>
        /// </div>
        /// </returns>
        public virtual object getStoreListeners(){return null;}
        /// <summary>
        /// Returns the parameter(s) that would be included in a standard form submit for this field. Typically this will be
        /// an object with a single name-value pair, the name being this field's name and the value being
        /// its current stringified value. More advanced field implementations may return more than one name-value pair.
        /// Note that the values returned from this method are not guaranteed to have been successfully <see cref="Ext.form.field.Field.validate">validated</see>.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>A mapping of submit parameter names to values; each value should be a string, or an array of
        /// strings if that particular name has multiple values. It can also return null if there are no parameters to be
        /// submitted.</p>
        /// </div>
        /// </returns>
        public virtual object getSubmitData(){return null;}
        /// <summary>
        /// Returns the value that would be included in a standard form submit for this field.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The value to be submitted, or null.</p>
        /// </div>
        /// </returns>
        public JsString getSubmitValue(){return null;}
        /// <summary>
        /// Returns the current data value of the field. The type of value returned is particular to the type of the
        /// particular field (e.g. a Date object for Ext.form.field.Date).
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>value The field value</p>
        /// </div>
        /// </returns>
        public virtual object getValue(){return null;}
        /// <summary>
        /// Initializes this Field mixin on the current instance. Components using this mixin should call this method during
        /// their own initialization process.
        /// </summary>
        public virtual void initField(){}
        /// <summary>
        /// Initializes the field's value based on the initial config.
        /// </summary>
        public virtual void initValue(){}
        /// <summary>
        /// Returns true if the value of this Field has been changed from its originalValue.
        /// Will always return false if the field is disabled.
        /// Note that if the owning <see cref="Ext.form.Basic">form</see> was configured with
        /// <see cref="Ext.form.BasicConfig.trackResetOnLoad">trackResetOnLoad</see> then the <see cref="Ext.form.field.Field.originalValue">originalValue</see> is updated when
        /// the values are loaded by <see cref="Ext.form.Basic">Ext.form.Basic</see>.<see cref="Ext.form.Basic.setValues">setValues</see>.
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this field has been changed from its original value (and is not disabled),
        /// false otherwise.</p>
        /// </div>
        /// </returns>
        public virtual bool isDirty(){return false;}
        /// <summary>
        /// Returns whether two field values are logically equal. Field implementations may override this
        /// to provide custom comparison logic appropriate for the particular field's data type.
        /// </summary>
        /// <param name="value1"><p>The first value to compare</p>
        /// </param>
        /// <param name="value2"><p>The second value to compare</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the values are equal, false if inequal.</p>
        /// </div>
        /// </returns>
        public virtual bool isEqual(object value1, object value2){return false;}
        /// <summary>
        /// Returns whether two values are logically equal.
        /// Similar to isEqual, however null or undefined values will be treated as empty strings.
        /// </summary>
        /// <param name="value1"><p>The first value to compare</p>
        /// </param>
        /// <param name="value2"><p>The second value to compare</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the values are equal, false if inequal.</p>
        /// </div>
        /// </returns>
        public virtual bool isEqualAsString(object value1, object value2){return false;}
        /// <summary>
        /// Returns whether this Field is a file upload field; if it returns true, forms will use special techniques for
        /// submitting the form via AJAX. See Ext.form.Basic.hasUpload for details. If
        /// this returns true, the extractFileInput method must also be implemented to return the corresponding file
        /// input element.
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public virtual bool isFileUpload(){return false;}
        /// <summary>
        /// Returns whether or not the field value is currently valid by validating the field's current
        /// value. The validitychange event will not be fired; use validate instead if you want the event
        /// to fire. Note: disabled fields are always treated as valid.
        /// Implementations are encouraged to ensure that this method does not have side-effects such as triggering error
        /// message display.
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the value is valid, else false</p>
        /// </div>
        /// </returns>
        public virtual bool isValid(){return false;}
        /// <summary>
        /// Associate one or more error messages with this field. Components using this mixin should implement this method to
        /// update the component's rendering to display the messages.
        /// <strong>Note</strong>: this method does not cause the Field's <see cref="Ext.form.field.Field.validate">validate</see> or <see cref="Ext.form.field.Field.isValid">isValid</see> methods to return <c>false</c>
        /// if the value does <em>pass</em> validation. So simply marking a Field as invalid will not prevent submission of forms
        /// submitted with the <see cref="Ext.form.action.SubmitConfig.clientValidation">Ext.form.action.Submit.clientValidation</see> option set.
        /// </summary>
        /// <param name="errors"><p>The error message(s) for the field.</p>
        /// </param>
        public virtual void markInvalid(object errors){}
        /// <summary>
        /// Template method, it is called when a new store is bound
        /// to the current instance.
        /// </summary>
        /// <param name="store"><p>The store being bound</p>
        /// </param>
        /// <param name="initial"><p>True if this store is being bound as initialization of the instance.</p>
        /// </param>
        public virtual void onBindStore(Ext.data.AbstractStore store, bool initial){}
        /// <summary>
        /// Called when the field's value changes. Performs validation if the validateOnChange
        /// config is enabled, and invokes the dirty check.
        /// </summary>
        /// <param name="newVal">
        /// </param>
        /// <param name="oldVal">
        /// </param>
        public virtual void onChange(object newVal, object oldVal){}
        /// <summary>
        /// Called when the field's dirty state changes.
        /// </summary>
        /// <param name="isDirty">
        /// </param>
        public virtual void onDirtyChange(bool isDirty){}
        /// <summary>
        /// Template method, it is called when an existing store is unbound
        /// from the current instance.
        /// </summary>
        /// <param name="store"><p>The store being unbound</p>
        /// </param>
        /// <param name="initial"><p>True if this store is being bound as initialization of the instance.</p>
        /// </param>
        public virtual void onUnbindStore(Ext.data.AbstractStore store, bool initial){}
        /// <summary>
        /// Resets the current field value to the originally loaded value and clears any validation messages. See Ext.form.Basic.trackResetOnLoad
        /// </summary>
        public virtual void reset(){}
        /// <summary>
        /// Resets the field's originalValue property so it matches the current value. This is
        /// called by Ext.form.Basic.setValues if the form's
        /// trackResetOnLoad property is set to true.
        /// </summary>
        public virtual void resetOriginalValue(){}
        /// <summary>
        /// Sets a data value into the field and runs the change detection and validation.
        /// </summary>
        /// <param name="value"><p>The value to set</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.form.field.Field">Ext.form.field.Field</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public virtual Ext.form.field.Field setValue(object value){return null;}
        /// <summary>
        /// Allows for any necessary modifications before the original
        /// value is set
        /// </summary>
        /// <param name="value"><p>The initial value</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The modified initial value</p>
        /// </div>
        /// </returns>
        public virtual object transformOriginalValue(object value){return null;}
        /// <summary>
        /// Unbinds listeners from this component to the store. By default it will remove
        /// anything bound by the bindStoreListeners method, however it can be overridden
        /// in a subclass to provide any more complicated handling.
        /// </summary>
        /// <param name="store"><p>The store to unbind from</p>
        /// </param>
        public virtual void unbindStoreListeners(Ext.data.AbstractStore store){}
        /// <summary>
        /// Returns whether or not the field value is currently valid by validating the field's current
        /// value, and fires the validitychange event if the field's validity has changed since the last validation.
        /// Note: disabled fields are always treated as valid.
        /// Custom implementations of this method are allowed to have side-effects such as triggering error message display.
        /// To validate without side-effects, use <see cref="Ext.form.field.Field.isValid">isValid</see>.
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the value is valid, else false</p>
        /// </div>
        /// </returns>
        public virtual bool validate(){return false;}
        public MultiSelect(MultiSelectConfig config){}
        public MultiSelect(){}
        public MultiSelect(params object[] args){}
    }
    #endregion
    #region MultiSelectConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MultiSelectConfig : Ext.form.FieldContainerConfig
    {
        /// <summary>
        /// False to require at least one item in the list to be selected, true to allow no
        /// selection.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowBlank;
        /// <summary>
        /// True if the list should only allow append drops when drag/drop is enabled.
        /// This is useful for lists which are sorted.
        /// Defaults to: <c>false</c>
        /// </summary>
        public JsString appendOnly;
        /// <summary>
        /// Default text displayed when the control contains no items.
        /// Defaults to: <c>&quot;This field is required&quot;</c>
        /// </summary>
        public JsString blankText;
        /// <summary>
        /// Whether the items in the MultiSelect list are drag/drop reorderable.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool ddReorder;
        /// <summary>
        /// The string used to delimit the selected values when submitting
        /// the field as part of a form. If you wish to have the selected values submitted as separate
        /// parameters rather than a single delimited parameter, set this to null.
        /// Defaults to: <c>&quot;,&quot;</c>
        /// </summary>
        public JsString delimiter;
        /// <summary>
        /// Name of the desired display field in the dataset.
        /// Defaults to: <c>&quot;text&quot;</c>
        /// </summary>
        public JsString displayField;
        /// <summary>
        /// The ddgroup name for the MultiSelect DragZone.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString dragGroup;
        /// <summary>
        /// The ddgroup name for the MultiSelect DropZone.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString dropGroup;
        /// <summary>
        /// An optional set of configuration properties that will be passed to the Ext.view.BoundList's constructor.
        /// Any configuration that is valid for BoundList can be included.
        /// </summary>
        public JsObject listConfig;
        /// <summary>
        /// Maximum number of selections allowed.
        /// Defaults to: <c>Number.MAX_VALUE</c>
        /// </summary>
        public JsNumber maxSelections;
        /// <summary>
        /// Validation message displayed when maxSelections is not met
        /// The {0} token will be replaced by the value of maxSelections.
        /// Defaults to: <c>&quot;Maximum {0}item(s) allowed&quot;</c>
        /// </summary>
        public JsString maxSelectionsText;
        /// <summary>
        /// Minimum number of selections allowed.
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber minSelections;
        /// <summary>
        /// Validation message displayed when minSelections is not met.
        /// The {0} token will be replaced by the value of minSelections.
        /// Defaults to: <c>&quot;Minimum {0}item(s) required&quot;</c>
        /// </summary>
        public JsString minSelectionsText;
        /// <summary>
        /// The name of the field. By default this is used as the parameter name when including the
        /// field value in a form submit(). To prevent the field from
        /// being included in the form submit, set submitValue to false.
        /// </summary>
        public JsString name;
        /// <summary>
        /// The data source to which this MultiSelect is bound (defaults to undefined).
        /// Acceptable values for this property are:
        /// <ul>
        /// <li><b>any <see cref="Ext.data.Store">Store</see> subclass</b></li>
        /// <li><b>an Array</b> : Arrays will be converted to a <see cref="Ext.data.ArrayStore">Ext.data.ArrayStore</see> internally.
        /// <div><ul>
        /// <li><b>1-dimensional array</b> : (e.g., <tt>['Foo','Bar']</tt>)<div>
        /// A 1-dimensional array will automatically be expanded (each array item will be the combo
        /// <see cref="Ext.ux.form.MultiSelectConfig.valueField">value</see> and <see cref="Ext.ux.form.MultiSelectConfig.displayField">text</see>)</div></li>
        /// <li><b>2-dimensional array</b> : (e.g., <tt>[['f','Foo'],['b','Bar']]</tt>)<div>
        /// For a multi-dimensional array, the value in index 0 of each item will be assumed to be the combo
        /// <see cref="Ext.ux.form.MultiSelectConfig.valueField">value</see>, while the value at index 1 is assumed to be the combo <see cref="Ext.ux.form.MultiSelectConfig.displayField">text</see>.
        /// </div></li></ul></div></li></ul>
        /// </summary>
        public object store;
        /// <summary>
        /// Setting this to false will prevent the field from being submitted even when it is
        /// not disabled.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitValue;
        /// <summary>
        /// An optional toolbar to be inserted at the top of the control's selection list.
        /// This can be a Ext.toolbar.Toolbar object, a toolbar config, or an array of buttons/button configs
        /// to be added to the toolbar. See Ext.panel.Panel.tbar.
        /// </summary>
        public object tbar;
        /// <summary>
        /// A title for the underlying panel.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString title;
        /// <summary>
        /// Specifies whether this field should be validated immediately whenever a change in its value is detected.
        /// If the validation results in a change in the field's validity, a validitychange event will be
        /// fired. This allows the field to show feedback about the validity of its contents immediately as the user is
        /// typing.
        /// When set to false, feedback will not be immediate. However the form will still be validated before submitting if
        /// the clientValidation option to <see cref="Ext.form.Basic.doAction">Ext.form.Basic.doAction</see> is enabled, or if the field or form are validated
        /// manually.
        /// See also <see cref="Ext.form.field.BaseConfig.checkChangeEvents">Ext.form.field.Base.checkChangeEvents</see> for controlling how changes to the field's value are
        /// detected.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool validateOnChange;
        /// <summary>
        /// A value to initialize this field with.
        /// </summary>
        public JsObject value;
        /// <summary>
        /// Name of the desired value field in the dataset.
        /// Defaults to: <c>&quot;text&quot;</c>
        /// </summary>
        public JsString valueField;
        public MultiSelectConfig(params object[] args){}
    }
    #endregion
    #region MultiSelectEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MultiSelectEvents : Ext.form.FieldContainerEvents
    {
        /// <summary>
        /// Fires when the value of a field is changed via the setValue method.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="newValue"><p>The new value</p>
        /// </param>
        /// <param name="oldValue"><p>The original value</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void change(Ext.form.field.Field @this, object newValue, object oldValue, object eOpts){}
        /// <summary>
        /// Fires when a change in the field's isDirty state is detected.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="isDirty"><p>Whether or not the field is now dirty</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void dirtychange(Ext.form.field.Field @this, bool isDirty, object eOpts){}
        /// <summary>
        /// Fires when a change in the field's validity is detected.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="isValid"><p>Whether or not the field is now valid</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void validitychange(Ext.form.field.Field @this, bool isValid, object eOpts){}
        public MultiSelectEvents(params object[] args){}
    }
    #endregion
}
