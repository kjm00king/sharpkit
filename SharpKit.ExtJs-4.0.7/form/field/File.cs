//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region File
    /// <summary>
    /// A file upload field which has custom styling and allows control over the button text and other
    /// features of text fields like empty text.
    /// It uses a hidden file input element behind the scenes to allow user selection of a file and to
    /// perform the actual upload during form submit. Because there is no secure cross-browser way to programmatically set the value of a file input,
    /// the standard Field setValue method is not implemented. The getValue method will return
    /// a value that is browser-dependent; some have just the file name, some have a full path, some use
    /// a fake path.
    /// Example Usage: Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;Upload a Photo&#39;,
    /// width: 400,
    /// bodyPadding: 10,
    /// frame: true,
    /// renderTo: Ext.getBody(),
    /// items: [{
    /// xtype: &#39;filefield&#39;,
    /// name: &#39;photo&#39;,
    /// fieldLabel: &#39;Photo&#39;,
    /// labelWidth: 50,
    /// msgTarget: &#39;side&#39;,
    /// allowBlank: false,
    /// anchor: &#39;100%&#39;,
    /// buttonText: &#39;Select Photo...&#39;
    /// }],
    /// buttons: [{
    /// text: &#39;Upload&#39;,
    /// handler: function() {
    /// var form = this.up(&#39;form&#39;).getForm();
    /// if(form.isValid()){
    /// form.submit({
    /// url: &#39;photo-upload.php&#39;,
    /// waitMsg: &#39;Uploading your photo...&#39;,
    /// success: function(fp, o) {
    /// Ext.Msg.alert(&#39;Success&#39;, &#39;Your photo &quot;&#39; + o.result.file + &#39;&quot; has been uploaded.&#39;);
    /// }
    /// });
    /// }
    /// }
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class File : Text, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// A reference to the trigger Button component created for this upload field. ...
        /// </summary>
        public Ext.button.Button button{get;set;}
        /// <summary>
        /// A reference to the invisible file input element created for this upload field. ...
        /// </summary>
        public Ext.core.Element fileInputEl{get;set;}
        public File(FileConfig config){}
        public File(){}
    }
    #endregion
    #region FileConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class FileConfig : TextConfig
    {
        public object buttonConfig{get;set;}
        /// <summary>
        /// The number of pixels of space reserved between the button and the text field
        /// (defaults to 3). ...
        /// </summary>
        public JsNumber buttonMargin{get;set;}
        /// <summary>
        /// True to display the file upload field as a button with no visible
        /// text field (defaults to false). ...
        /// </summary>
        public bool buttonOnly{get;set;}
        /// <summary>
        /// The button text to display on the upload button (defaults to
        /// 'Browse...'). ...
        /// </summary>
        public JsString buttonText{get;set;}
        /// <summary>
        /// An extra CSS class to be applied to the body content element in addition to fieldBodyCls. ...
        /// </summary>
        public new JsString fieldBodyCls{get;set;}
    }
    #endregion
    #region FileEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class FileEvents : TextEvents
    {
        /// <summary>
        /// Fires when the underlying file input field's value has changed from the user
        /// selecting a new file from the system fil...
        /// </summary>
        public static new JsString change="change";
    }
    #endregion
}
#endregion
