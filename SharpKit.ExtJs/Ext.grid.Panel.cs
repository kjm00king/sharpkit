//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid
namespace Ext.grid
{
    #region Panel
    /// <inheritdocs />
    /// <summary>
    /// <p>Grids are an excellent way of showing large amounts of tabular data on the client side. Essentially a supercharged
    /// <c>&lt;table&gt;</c>, GridPanel makes it easy to fetch, sort and filter large amounts of data.</p>
    /// <p>Grids are composed of two main pieces - a <see cref="Ext.data.Store">Store</see> full of data and a set of columns to render.</p>
    /// <h2>Basic GridPanel</h2>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// storeId:'simpsonsStore',
    /// fields:['name', 'email', 'phone'],
    /// data:{'items':[
    /// { 'name': 'Lisa',  "email":"lisa@simpsons.com",  "phone":"555-111-1224"  },
    /// { 'name': 'Bart',  "email":"bart@simpsons.com",  "phone":"555-222-1234" },
    /// { 'name': 'Homer', "email":"home@simpsons.com",  "phone":"555-222-1244"  },
    /// { 'name': 'Marge', "email":"marge@simpsons.com", "phone":"555-222-1254"  }
    /// ]},
    /// proxy: {
    /// type: 'memory',
    /// reader: {
    /// type: 'json',
    /// root: 'items'
    /// }
    /// }
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// title: 'Simpsons',
    /// store: <see cref="Ext.data.StoreManager.lookup">Ext.data.StoreManager.lookup</see>('simpsonsStore'),
    /// columns: [
    /// { text: 'Name',  dataIndex: 'name' },
    /// { text: 'Email', dataIndex: 'email', flex: 1 },
    /// { text: 'Phone', dataIndex: 'phone' }
    /// ],
    /// height: 200,
    /// width: 400,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// <p>The code above produces a simple grid with three columns. We specified a Store which will load JSON data inline.
    /// In most apps we would be placing the grid inside another container and wouldn't need to use the
    /// <see cref="Ext.grid.PanelConfig.height">height</see>, <see cref="Ext.grid.PanelConfig.width">width</see> and <see cref="Ext.grid.PanelConfig.renderTo">renderTo</see> configurations but they are included here to make it easy to get
    /// up and running.</p>
    /// <p>The grid we created above will contain a header bar with a title ('Simpsons'), a row of column headers directly underneath
    /// and finally the grid rows under the headers.</p>
    /// <h2>Configuring columns</h2>
    /// <p>By default, each column is sortable and will toggle between ASC and DESC sorting when you click on its header. Each
    /// column header is also reorderable by default, and each gains a drop-down menu with options to hide and show columns.
    /// It's easy to configure each column - here we use the same example as above and just modify the columns config:</p>
    /// <pre><code>columns: [
    /// {
    /// text: 'Name',
    /// dataIndex: 'name',
    /// sortable: false,
    /// hideable: false,
    /// flex: 1
    /// },
    /// {
    /// text: 'Email',
    /// dataIndex: 'email',
    /// hidden: true
    /// },
    /// {
    /// text: 'Phone',
    /// dataIndex: 'phone',
    /// width: 100
    /// }
    /// ]
    /// </code></pre>
    /// <p>We turned off sorting and hiding on the 'Name' column so clicking its header now has no effect. We also made the Email
    /// column hidden by default (it can be shown again by using the menu on any other column). We also set the Phone column to
    /// a fixed with of 100px and flexed the Name column, which means it takes up all remaining width after the other columns
    /// have been accounted for. See the <see cref="Ext.grid.column.Column">column docs</see> for more details.</p>
    /// <h2>Renderers</h2>
    /// <p>As well as customizing columns, it's easy to alter the rendering of individual cells using renderers. A renderer is
    /// tied to a particular column and is passed the value that would be rendered into each cell in that column. For example,
    /// we could define a renderer function for the email column to turn each email address into a mailto link:</p>
    /// <pre><code>columns: [
    /// {
    /// text: 'Email',
    /// dataIndex: 'email',
    /// renderer: function(value) {
    /// return <see cref="Ext.String.format">Ext.String.format</see>('&lt;a href="mailto:{0}"&gt;{1}&lt;/a&gt;', value, value);
    /// }
    /// }
    /// ]
    /// </code></pre>
    /// <p>See the <see cref="Ext.grid.column.Column">column docs</see> for more information on renderers.</p>
    /// <h2>Selection Models</h2>
    /// <p>Sometimes all you want is to render data onto the screen for viewing, but usually it's necessary to interact with or
    /// update that data. Grids use a concept called a Selection Model, which is simply a mechanism for selecting some part of
    /// the data in the grid. The two main types of Selection Model are RowSelectionModel, where entire rows are selected, and
    /// CellSelectionModel, where individual cells are selected.</p>
    /// <p>Grids use a Row Selection Model by default, but this is easy to customise like so:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// selType: 'cellmodel',
    /// store: ...
    /// });
    /// </code></pre>
    /// <p>Specifying the <c>cellmodel</c> changes a couple of things. Firstly, clicking on a cell now
    /// selects just that cell (using a <see cref="Ext.selection.RowModel">rowmodel</see> will select the entire row), and secondly the
    /// keyboard navigation will walk from cell to cell instead of row to row. Cell-based selection models are usually used in
    /// conjunction with editing.</p>
    /// <h2>Sorting &amp; Filtering</h2>
    /// <p>Every grid is attached to a <see cref="Ext.data.Store">Store</see>, which provides multi-sort and filtering capabilities. It's
    /// easy to set up a grid to be sorted from the start:</p>
    /// <pre><code>var myGrid = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// store: {
    /// fields: ['name', 'email', 'phone'],
    /// sorters: ['name', 'phone']
    /// },
    /// columns: [
    /// { text: 'Name',  dataIndex: 'name' },
    /// { text: 'Email', dataIndex: 'email' }
    /// ]
    /// });
    /// </code></pre>
    /// <p>Sorting at run time is easily accomplished by simply clicking each column header. If you need to perform sorting on
    /// more than one field at run time it's easy to do so by adding new sorters to the store:</p>
    /// <pre><code>myGrid.store.sort([
    /// { property: 'name',  direction: 'ASC' },
    /// { property: 'email', direction: 'DESC' }
    /// ]);
    /// </code></pre>
    /// <p>See <see cref="Ext.data.Store">Ext.data.Store</see> for examples of filtering.</p>
    /// <h2>State saving</h2>
    /// <p>When configured <see cref="Ext.grid.PanelConfig.stateful">stateful</see>, grids save their column state (order and width) encapsulated within the default
    /// Panel state of changed width and height and collapsed/expanded state.</p>
    /// <p>Each <see cref="Ext.grid.PanelConfig.columns">column</see> of the grid may be configured with a <see cref="Ext.grid.column.ColumnConfig.stateId">stateId</see> which
    /// identifies that column locally within the grid.</p>
    /// <h2>Plugins and Features</h2>
    /// <p>Grid supports addition of extra functionality through features and plugins:</p>
    /// <ul>
    /// <li><p><see cref="Ext.grid.plugin.CellEditing">CellEditing</see> - editing grid contents one cell at a time.</p></li>
    /// <li><p><see cref="Ext.grid.plugin.RowEditing">RowEditing</see> - editing grid contents an entire row at a time.</p></li>
    /// <li><p><see cref="Ext.grid.plugin.DragDrop">DragDrop</see> - drag-drop reordering of grid rows.</p></li>
    /// <li><p><see cref="Ext.toolbar.Paging">Paging toolbar</see> - paging through large sets of data.</p></li>
    /// <li><p><see cref="Ext.grid.PagingScroller">Infinite scrolling</see> - another way to handle large sets of data.</p></li>
    /// <li><p><see cref="Ext.grid.RowNumberer">RowNumberer</see> - automatically numbered rows.</p></li>
    /// <li><p><see cref="Ext.grid.feature.Grouping">Grouping</see> - grouping together rows having the same value in a particular field.</p></li>
    /// <li><p><see cref="Ext.grid.feature.Summary">Summary</see> - a summary row at the bottom of a grid.</p></li>
    /// <li><p><see cref="Ext.grid.feature.GroupingSummary">GroupingSummary</see> - a summary row at the bottom of each group.</p></li>
    /// </ul>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Panel : Ext.panel.Table
    {
        /// <summary>
        /// Reconfigures the grid with a new store/columns. Either the store or the columns can be omitted if you don't wish
        /// to change them.
        /// </summary>
        /// <param name="store"><p>The new store.</p>
        /// </param>
        /// <param name="columns"><p>An array of column configs</p>
        /// </param>
        public void reconfigure(object store=null, object columns=null){}
        public Panel(Ext.grid.PanelConfig config){}
        public Panel(){}
        public Panel(params object[] args){}
    }
    #endregion
    #region PanelConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PanelConfig : Ext.panel.TableConfig
    {
        public PanelConfig(params object[] args){}
    }
    #endregion
    #region PanelEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PanelEvents : Ext.panel.TableEvents
    {
        /// <summary>
        /// Fires after a reconfigure.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="store"><p>The store that was passed to the <see cref="Ext.grid.Panel.reconfigure">reconfigure</see> method</p>
        /// </param>
        /// <param name="columns"><p>The column configs that were passed to the <see cref="Ext.grid.Panel.reconfigure">reconfigure</see> method</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void reconfigure(Ext.grid.Panel @this, Ext.data.Store store, JsArray<Object> columns, object eOpts){}
        public PanelEvents(params object[] args){}
    }
    #endregion
}
#endregion