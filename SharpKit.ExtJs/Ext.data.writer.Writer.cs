//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data.writer
{
    #region Writer
    /// <inheritdocs />
    /// <summary>
    /// <p>Base Writer class used by most subclasses of <see cref="Ext.data.proxy.Server">Ext.data.proxy.Server</see>. This class is responsible for taking a
    /// set of <see cref="Ext.data.Operation">Ext.data.Operation</see> objects and a <see cref="Ext.data.Request">Ext.data.Request</see> object and modifying that request based on
    /// the Operations.</p>
    /// <p>For example a <see cref="Ext.data.writer.Json">Ext.data.writer.Json</see> would format the Operations and their <see cref="Ext.data.Model">Ext.data.Model</see> instances based on
    /// the config options passed to the JsonWriter's constructor.</p>
    /// <p>Writers are not needed for any kind of local storage - whether via a <see cref="Ext.data.proxy.WebStorage">Web Storage
    /// proxy</see> (see <see cref="Ext.data.proxy.LocalStorage">localStorage</see> and <see cref="Ext.data.proxy.SessionStorage">sessionStorage</see>) or just in memory via a <see cref="Ext.data.proxy.Memory">MemoryProxy</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Writer : Ext.Base
    {
        /// <summary>
        /// This property is used to read the key for each value that will be sent to the server. For example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('Person', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: [{
        /// name: 'first',
        /// mapping: 'firstName'
        /// }, {
        /// name: 'last',
        /// mapping: 'lastName'
        /// }, {
        /// name: 'age'
        /// }]
        /// });
        /// new <see cref="Ext.data.writer.Writer">Ext.data.writer.Writer</see>({
        /// writeAllFields: true,
        /// nameProperty: 'mapping'
        /// });
        /// // This will be sent to the server
        /// {
        /// firstName: 'first name value',
        /// lastName: 'last name value',
        /// age: 1
        /// }
        /// </code>
        /// If the value is not present, the field name will always be used.
        /// Defaults to: <c>&quot;name&quot;</c>
        /// </summary>
        public JsString nameProperty;
        /// <summary>
        /// True to write all fields from the record to the server. If set to false it will only send the fields that were
        /// modified. Note that any fields that have Ext.data.Field.persist set to false will still be ignored.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool writeAllFields;
        /// <summary>
        /// Creates new Writer.
        /// </summary>
        /// <param name="config"><p>Config object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Writer(object config=null){}
        /// <summary>
        /// Formats the data for each record before sending it to the server. This
        /// method should be overridden to format the data in a way that differs from the default.
        /// </summary>
        /// <param name="record"><p>The record that we are writing to the server.</p>
        /// </param>
        /// <param name="operation"><p>An operation object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>An object literal of name/value keys to be written to the server.
        /// By default this method returns the data property on the record.</p>
        /// </div>
        /// </returns>
        public object getRecordData(Ext.data.Model record, object operation=null){return null;}
        /// <summary>
        /// Prepares a Proxy's Ext.data.Request object
        /// </summary>
        /// <param name="request"><p>The request object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.data.Request">Ext.data.Request</see></span><div><p>The modified request object</p>
        /// </div>
        /// </returns>
        public Request write(Request request){return null;}
        public Writer(WriterConfig config){}
        public Writer(params object[] args){}
    }
    #endregion
    #region WriterConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class WriterConfig : Ext.BaseConfig
    {
        /// <summary>
        /// This property is used to read the key for each value that will be sent to the server. For example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('Person', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: [{
        /// name: 'first',
        /// mapping: 'firstName'
        /// }, {
        /// name: 'last',
        /// mapping: 'lastName'
        /// }, {
        /// name: 'age'
        /// }]
        /// });
        /// new <see cref="Ext.data.writer.Writer">Ext.data.writer.Writer</see>({
        /// writeAllFields: true,
        /// nameProperty: 'mapping'
        /// });
        /// // This will be sent to the server
        /// {
        /// firstName: 'first name value',
        /// lastName: 'last name value',
        /// age: 1
        /// }
        /// </code>
        /// If the value is not present, the field name will always be used.
        /// Defaults to: <c>&quot;name&quot;</c>
        /// </summary>
        public JsString nameProperty;
        /// <summary>
        /// True to write all fields from the record to the server. If set to false it will only send the fields that were
        /// modified. Note that any fields that have Ext.data.Field.persist set to false will still be ignored.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool writeAllFields;
        public WriterConfig(params object[] args){}
    }
    #endregion
    #region WriterEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class WriterEvents : Ext.BaseEvents
    {
        public WriterEvents(params object[] args){}
    }
    #endregion
}
