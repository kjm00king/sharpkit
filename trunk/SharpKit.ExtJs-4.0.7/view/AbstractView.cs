//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************

using Ext.data;
using SharpKit.JavaScript;
using Ext.Unknown;
#region Ext.view
namespace Ext.view
{
    #region AbstractView
    /// <summary>
    /// This is an abstract superclass and should not be used directly. Please see Ext.view.View.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class AbstractView : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Changes the data store bound to this view and refreshes it. ...
        /// </summary>
        public object bindStore(Ext.data.Store store, object initial){return null;}
        /// <summary>
        /// Function which can be overridden which returns the data object passed to this
        /// DataView's template to render the whole...
        /// </summary>
        public JsArray collectData(JsArray records, JsNumber startIndex){return null;}
        /// <summary>
        /// Deselects a record instance by record instance or index. ...
        /// </summary>
        public object deselect(object records, bool suppressEvent){return null;}
        /// <summary>
        /// Returns the template node the passed child belongs to, or null if it doesn't belong to one. ...
        /// </summary>
        public HTMLElement findItemByChild(HTMLElement node){return null;}
        /// <summary>
        /// Returns the template node by the Ext.EventObject or null if it is not found. ...
        /// </summary>
        public object findTargetByEvent(Ext.EventObject e){return null;}
        /// <summary>
        /// Gets a template node. ...
        /// </summary>
        public HTMLElement getNode(object nodeInfo){return null;}
        /// <summary>
        /// Gets a range nodes. ...
        /// </summary>
        public JsArray getNodes(JsNumber start=null, JsNumber end=null){return null;}
        /// <summary>
        /// Gets a record from a node ...
        /// </summary>
        public Model getRecord(object node){return null;}
        /// <summary>
        /// Gets an array of the records from an array of nodes ...
        /// </summary>
        public JsArray getRecords(JsArray nodes){return null;}
        /// <summary>
        /// Gets the currently selected nodes. ...
        /// </summary>
        public JsArray getSelectedNodes(){return null;}
        /// <summary>
        /// Gets an array of the selected records ...
        /// </summary>
        public JsArray getSelectedRecords(){return null;}
        /// <summary>
        /// Gets the number of selected nodes. ...
        /// </summary>
        public JsNumber getSelectionCount(){return null;}
        /// <summary>
        /// Gets the selection model for this view. ...
        /// </summary>
        public Ext.selection.Model getSelectionModel(){return null;}
        /// <summary>
        /// Returns the store associated with this DataView. ...
        /// </summary>
        public Ext.data.Store getStore(){return null;}
        /// <summary>
        /// Finds the index of the passed node. ...
        /// </summary>
        public JsNumber indexOf(object nodeInfo){return null;}
        /// <summary>
        /// Returns true if the passed node is selected, else false. ...
        /// </summary>
        public bool isSelected(object node){return false;}
        /// <summary>
        /// Function which can be overridden to provide custom formatting for each Record that is used by this
        /// DataView's templat...
        /// </summary>
        public object prepareData(object data, JsNumber recordIndex, Record record){return null;}
        /// <summary>
        /// Refreshes the view by reloading the data from the store and re-rendering the template. ...
        /// </summary>
        public object refresh(){return null;}
        /// <summary>
        /// Refreshes an individual node's data from the store. ...
        /// </summary>
        public object refreshNode(JsNumber index){return null;}
        /// <summary>
        /// Selects a record instance by record instance or index. ...
        /// </summary>
        public object select(object records, bool keepExisting, bool suppressEvent){return null;}
        public AbstractView(AbstractViewConfig config){}
        public AbstractView(){}
    }
    #endregion
    #region AbstractViewConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractViewConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// Set this to true to ignore datachanged events on the bound store. ...
        /// </summary>
        public bool blockRefresh{get;set;}
        public bool deferEmptyText{get;set;}
        /// <summary>
        /// true to disable selection within the DataView. ...
        /// </summary>
        public bool disableSelection{get;set;}
        /// <summary>
        /// The text to display in the view when there is no data to display (defaults to ''). ...
        /// </summary>
        public JsString emptyText{get;set;}
        public JsString itemCls{get;set;}
        /// <summary>
        /// @required
        /// This is a required setting. ...
        /// </summary>
        public JsString itemSelector{get;set;}
        /// <summary>
        /// The inner portion of the item template to be rendered. ...
        /// </summary>
        public object itemTpl{get;set;}
        /// <summary>
        /// False to disable a load mask from displaying will the view is loading. ...
        /// </summary>
        public object loadMask{get;set;}
        public JsString loadingCls{get;set;}
        /// <summary>
        /// If specified, gives an explicit height for the data view when it is showing the loadingText,
        /// if that is specified. ...
        /// </summary>
        public JsNumber loadingHeight{get;set;}
        /// <summary>
        /// A string to display during data load operations (defaults to undefined). ...
        /// </summary>
        public JsString loadingText{get;set;}
        /// <summary>
        /// True to allow selection of more than one item at a time, false to allow selection of only a single item
        /// at a time or ...
        /// </summary>
        public bool multiSelect{get;set;}
        /// <summary>
        /// A CSS class to apply to each item in the view on mouseover (defaults to undefined). ...
        /// </summary>
        public JsString overItemCls{get;set;}
        public JsString selectedItemCls{get;set;}
        /// <summary>
        /// True to enable multiselection by clicking on multiple items without requiring the user to hold Shift or Ctrl,
        /// false t...
        /// </summary>
        public bool simpleSelect{get;set;}
        /// <summary>
        /// True to allow selection of exactly one item at a time, false to allow no selection at all (defaults to false). ...
        /// </summary>
        public bool singleSelect{get;set;}
        public Ext.data.Store store{get;set;}
        /// <summary>
        /// @required
        /// The HTML fragment or an array of fragments that will make up the template used by this DataView. ...
        /// </summary>
        public new object tpl{get;set;}
        public bool trackOver{get;set;}
    }
    #endregion
    #region AbstractViewEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractViewEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires before the view is refreshed ...
        /// </summary>
        public static JsString beforerefresh="beforerefresh";
        /// <summary>
        /// Fires when the nodes associated with an recordset have been added to the underlying store ...
        /// </summary>
        public static JsString itemadd="itemadd";
        /// <summary>
        /// Fires when the node associated with an individual record is removed ...
        /// </summary>
        public static JsString itemremove="itemremove";
        /// <summary>
        /// Fires when the node associated with an individual record is updated ...
        /// </summary>
        public static JsString itemupdate="itemupdate";
        /// <summary>
        /// Fires when the view is refreshed ...
        /// </summary>
        public static JsString refresh="refresh";
    }
    #endregion
}
#endregion
