//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form
{
    #region CheckboxGroup
    /// <inheritdocs />
    /// <summary>
    /// <p>A <see cref="Ext.form.FieldContainer">field container</see> which has a specialized layout for arranging
    /// <see cref="Ext.form.field.Checkbox">Ext.form.field.Checkbox</see> controls into columns, and provides convenience
    /// <see cref="Ext.form.field.Field">Ext.form.field.Field</see> methods for <see cref="Ext.form.CheckboxGroup.getValue">getting</see>, <see cref="Ext.form.CheckboxGroup.setValue">setting</see>,
    /// and <see cref="Ext.form.CheckboxGroup.validate">validating</see> the group of checkboxes as a whole.</p>
    /// <h1>Validation</h1>
    /// <p>Individual checkbox fields themselves have no default validation behavior, but
    /// sometimes you want to require a user to select at least one of a group of checkboxes. CheckboxGroup
    /// allows this by setting the config <c><see cref="Ext.form.CheckboxGroupConfig.allowBlank">allowBlank</see>:false</c>; when the user does not check at
    /// least one of the checkboxes, the entire group will be highlighted as invalid and the
    /// <see cref="Ext.form.CheckboxGroupConfig.blankText">error message</see> will be displayed according to the <see cref="Ext.form.CheckboxGroupConfig.msgTarget">msgTarget</see> config.</p>
    /// <h1>Layout</h1>
    /// <p>The default layout for CheckboxGroup makes it easy to arrange the checkboxes into
    /// columns; see the <see cref="Ext.form.CheckboxGroupConfig.columns">columns</see> and <see cref="Ext.form.CheckboxGroupConfig.vertical">vertical</see> config documentation for details. You may also
    /// use a completely different layout by setting the <see cref="Ext.form.CheckboxGroupConfig.layout">layout</see> to one of the other supported layout
    /// types; for instance you may wish to use a custom arrangement of hbox and vbox containers. In that case
    /// the checkbox components at any depth will still be managed by the CheckboxGroup's validation.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// title: 'Checkbox Group',
    /// width: 300,
    /// height: 125,
    /// bodyPadding: 10,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items:[{
    /// xtype: 'checkboxgroup',
    /// fieldLabel: 'Two Columns',
    /// // Arrange checkboxes into two columns, distributed vertically
    /// columns: 2,
    /// vertical: true,
    /// items: [
    /// { boxLabel: 'Item 1', name: 'rb', inputValue: '1' },
    /// { boxLabel: 'Item 2', name: 'rb', inputValue: '2', checked: true },
    /// { boxLabel: 'Item 3', name: 'rb', inputValue: '3' },
    /// { boxLabel: 'Item 4', name: 'rb', inputValue: '4' },
    /// { boxLabel: 'Item 5', name: 'rb', inputValue: '5' },
    /// { boxLabel: 'Item 6', name: 'rb', inputValue: '6' }
    /// ]
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class CheckboxGroup : Ext.form.FieldContainer, Ext.form.field.Field
    {
        /// <summary>
        /// False to validate that at least one item in the group is checked. If no items are selected at
        /// validation time, blankText will be used as the error text.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowBlank;
        /// <summary>
        /// Error text to display if the allowBlank validation fails
        /// Defaults to: <c>&quot;You must select at least one item in this group&quot;</c>
        /// </summary>
        public JsString blankText;
        /// <summary>
        /// Specifies the number of columns to use when displaying grouped checkbox/radio controls using automatic layout.
        /// This config can take several types of values:
        /// <li>'auto' - The controls will be rendered one per column on one row and the width of each column will be evenly
        /// distributed based on the width of the overall field container. This is the default.</li>
        /// <li>Number - If you specific a number (e.g., 3) that number of columns will be created and the contained controls
        /// will be automatically distributed based on the value of <see cref="Ext.form.CheckboxGroupConfig.vertical">vertical</see>.</li>
        /// <li>Array - You can also specify an array of column widths, mixing integer (fixed width) and float (percentage
        /// width) values as needed (e.g., [100, .25, .75]). Any integer values will be rendered first, then any float
        /// values will be calculated as a percentage of the remaining space. Float values do not have to add up to 1
        /// (100%) although if you want the controls to take up the entire field container you should do so.</li>
        /// Defaults to: <c>&quot;auto&quot;</c>
        /// </summary>
        public object columns;
        /// <summary>
        /// Overrides: <see cref="Ext.form.field.FieldConfig.name">Ext.form.field.Field.name</see>
        /// </summary>
        public JsString name;
        /// <summary>
        /// Setting this to false will prevent the field from being submitted even when it is
        /// not disabled.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitValue;
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
        /// True to distribute contained controls across columns, completely filling each column top to bottom before
        /// starting on the next column. The number of controls in each column will be automatically calculated to keep
        /// columns as even as possible. The default value is false, so that controls will be added to columns one at a time,
        /// completely filling each row left to right before starting on the next row.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool vertical;
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
        /// Clear any invalid styles/messages for this field. Components using this mixin should implement this method to
        /// update the components rendering to clear any existing messages.
        /// <strong>Note</strong>: this method does not cause the Field's <see cref="Ext.form.field.Field.validate">validate</see> or <see cref="Ext.form.field.Field.isValid">isValid</see> methods to return <c>true</c>
        /// if the value does not <em>pass</em> validation. So simply clearing a field's errors will not necessarily allow
        /// submission of forms submitted with the <see cref="Ext.form.action.SubmitConfig.clientValidation">Ext.form.action.Submit.clientValidation</see> option set.
        /// </summary>
        public virtual void clearInvalid(){}
        /// <summary>
        /// Convenience function which calls the given function for every checkbox in the group
        /// </summary>
        /// <param name="fn"><p>The function to call</p>
        /// </param>
        /// <param name="scope"><p>scope object</p>
        /// </param>
        private void eachBox(System.Delegate fn, object scope=null){}
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
        /// Returns all checkbox components within the container
        /// </summary>
        /// <param name="query"><p>An additional query to add to the selector.</p>
        /// </param>
        private void getBoxes(object query=null){}
        /// <summary>
        /// Returns an Array of all checkboxes in the container which are currently checked
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.form.field.Checkbox">Ext.form.field.Checkbox</see>[]</span><div><p>Array of <see cref="Ext.form.field.Checkbox">Ext.form.field.Checkbox</see> components</p>
        /// </div>
        /// </returns>
        public Ext.form.field.Checkbox[] getChecked(){return null;}
        /// <summary>
        /// Runs CheckboxGroup's validations and returns an array of any errors. The only error by default is if allowBlank
        /// is set to true and no items are checked.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see>[]</span><div><p>Array of all validation errors</p>
        /// </div>
        /// </returns>
        public JsString[] getErrors(){return null;}
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
        /// Returns an object containing the values of all checked checkboxes within the group. Each key-value pair in the
        /// object corresponds to a checkbox name. If there is only one checked checkbox
        /// with a particular name, the value of that pair will be the String inputValue of that checkbox. If there are multiple checked checkboxes with that name, the value of that pair
        /// will be an Array of the selected inputValues.
        /// The object format returned from this method can also be passed directly to the <see cref="Ext.form.CheckboxGroup.setValue">setValue</see> method.
        /// NOTE: In Ext 3, this method returned an array of Checkbox components; this was changed to make it more consistent
        /// with other field components and with the <see cref="Ext.form.CheckboxGroup.setValue">setValue</see> argument signature. If you need the old behavior in
        /// Ext 4+, use the <see cref="Ext.form.CheckboxGroup.getChecked">getChecked</see> method instead.
        /// Overrides: <see cref="Ext.form.field.Field.getValue">Ext.form.field.Field.getValue</see>
        /// </summary>
        public virtual object getValue(){return null;}
        /// <summary>
        /// Initializes this Field mixin on the current instance. Components using this mixin should call this method during
        /// their own initialization process.
        /// </summary>
        public virtual void initField(){}
        /// <summary>
        /// Initializes the field's value based on the initial config. If the value config is specified then we use
        /// that to set the value; otherwise we initialize the originalValue by querying the values of all sub-checkboxes
        /// after they have been initialized.
        /// Overrides: <see cref="Ext.form.field.Field.initValue">Ext.form.field.Field.initValue</see>
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
        /// Resets the checked state of all checkboxes in the group to their originally
        /// loaded values and clears any validation messages.
        /// See Ext.form.Basic.trackResetOnLoad
        /// Overrides: <see cref="Ext.form.field.Field.reset">Ext.form.field.Field.reset</see>
        /// </summary>
        public virtual void reset(){}
        /// <summary>
        /// Resets the field's originalValue property so it matches the current value. This is
        /// called by Ext.form.Basic.setValues if the form's
        /// trackResetOnLoad property is set to true.
        /// </summary>
        public virtual void resetOriginalValue(){}
        /// <summary>
        /// Sets the value(s) of all checkboxes in the group. The expected format is an Object of name-value pairs
        /// corresponding to the names of the checkboxes in the group. Each pair can have either a single or multiple values:
        /// <li>A single Boolean or String value will be passed to the <c>setValue</c> method of the checkbox with that name.
        /// See the rules in <see cref="Ext.form.field.Checkbox.setValue">Ext.form.field.Checkbox.setValue</see> for accepted values.</li>
        /// <li>An Array of String values will be matched against the <see cref="Ext.form.field.CheckboxConfig.inputValue">inputValue</see>
        /// of checkboxes in the group with that name; those checkboxes whose inputValue exists in the array will be
        /// checked and others will be unchecked.</li>
        /// If a checkbox's name is not in the mapping at all, it will be unchecked.
        /// An example:
        /// <code>var myCheckboxGroup = new <see cref="Ext.form.CheckboxGroup">Ext.form.CheckboxGroup</see>({
        /// columns: 3,
        /// items: [{
        /// name: 'cb1',
        /// boxLabel: 'Single 1'
        /// }, {
        /// name: 'cb2',
        /// boxLabel: 'Single 2'
        /// }, {
        /// name: 'cb3',
        /// boxLabel: 'Single 3'
        /// }, {
        /// name: 'cbGroup',
        /// boxLabel: 'Grouped 1'
        /// inputValue: 'value1'
        /// }, {
        /// name: 'cbGroup',
        /// boxLabel: 'Grouped 2'
        /// inputValue: 'value2'
        /// }, {
        /// name: 'cbGroup',
        /// boxLabel: 'Grouped 3'
        /// inputValue: 'value3'
        /// }]
        /// });
        /// myCheckboxGroup.setValue({
        /// cb1: true,
        /// cb3: false,
        /// cbGroup: ['value1', 'value3']
        /// });
        /// </code>
        /// The above code will cause the checkbox named 'cb1' to be checked, as well as the first and third checkboxes named
        /// 'cbGroup'. The other three checkboxes will be unchecked.
        /// </summary>
        /// <param name="value"><p>The mapping of checkbox names to values.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.form.CheckboxGroup">Ext.form.CheckboxGroup</see></span><div><p>this</p>
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
        /// <summary>
        /// Runs this field's validators and returns an array of error messages for any validation failures. This is called
        /// internally during validation and would not usually need to be used manually.
        /// Each subclass should override or augment the return value to provide their own errors.
        /// </summary>
        public virtual JsString[] getErrors(object value=null){return null;}
        public CheckboxGroup(Ext.form.CheckboxGroupConfig config){}
        public CheckboxGroup(){}
        public CheckboxGroup(params object[] args){}
    }
    #endregion
    #region CheckboxGroupConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CheckboxGroupConfig : Ext.form.FieldContainerConfig
    {
        /// <summary>
        /// False to validate that at least one item in the group is checked. If no items are selected at
        /// validation time, blankText will be used as the error text.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowBlank;
        /// <summary>
        /// Error text to display if the allowBlank validation fails
        /// Defaults to: <c>&quot;You must select at least one item in this group&quot;</c>
        /// </summary>
        public JsString blankText;
        /// <summary>
        /// Specifies the number of columns to use when displaying grouped checkbox/radio controls using automatic layout.
        /// This config can take several types of values:
        /// <li>'auto' - The controls will be rendered one per column on one row and the width of each column will be evenly
        /// distributed based on the width of the overall field container. This is the default.</li>
        /// <li>Number - If you specific a number (e.g., 3) that number of columns will be created and the contained controls
        /// will be automatically distributed based on the value of <see cref="Ext.form.CheckboxGroupConfig.vertical">vertical</see>.</li>
        /// <li>Array - You can also specify an array of column widths, mixing integer (fixed width) and float (percentage
        /// width) values as needed (e.g., [100, .25, .75]). Any integer values will be rendered first, then any float
        /// values will be calculated as a percentage of the remaining space. Float values do not have to add up to 1
        /// (100%) although if you want the controls to take up the entire field container you should do so.</li>
        /// Defaults to: <c>&quot;auto&quot;</c>
        /// </summary>
        public object columns;
        /// <summary>
        /// Overrides: <see cref="Ext.form.field.FieldConfig.name">Ext.form.field.Field.name</see>
        /// </summary>
        public JsString name;
        /// <summary>
        /// Setting this to false will prevent the field from being submitted even when it is
        /// not disabled.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitValue;
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
        /// True to distribute contained controls across columns, completely filling each column top to bottom before
        /// starting on the next column. The number of controls in each column will be automatically calculated to keep
        /// columns as even as possible. The default value is false, so that controls will be added to columns one at a time,
        /// completely filling each row left to right before starting on the next row.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool vertical;
        public CheckboxGroupConfig(params object[] args){}
    }
    #endregion
    #region CheckboxGroupEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CheckboxGroupEvents : Ext.form.FieldContainerEvents
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
        public CheckboxGroupEvents(params object[] args){}
    }
    #endregion
}
