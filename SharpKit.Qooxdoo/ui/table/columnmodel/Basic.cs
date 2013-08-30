// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.columnmodel
{
    /// <summary>
	/// <para>A model that contains all meta data about columns, such as width, renderer,
	/// visibility and order.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.columnmodel.Basic", OmitOptionalParameters = true, Export = false)]
    public partial class Basic : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired when the cell renderer of a column has changed.
		/// The data property of the event is a map having the following attributes:
		/// <list type="bullet">
		/// <item>col: The model index of the column that was moved.</item>
		/// </list</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnHeaderCellRendererChanged;

		/// <summary>
		/// <para>Fired when the column order has changed. The data property of the
		/// event is a map having the following attributes:
		/// <list type="bullet">
		/// <item>col: The model index of the column that was moved.</item>
		/// <item>fromOverXPos: The old overall x position of the column.</item>
		/// <item>toOverXPos: The new overall x position of the column.</item>
		/// </list</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnOrderChanged;

		/// <summary>
		/// <para>Fired when the visibility of a column has changed. The data property of the
		/// event is a map having the following attributes:
		/// <list type="bullet">
		/// <item>col: The model index of the column the visibility of which has changed.</item>
		/// <item>visible: Whether the column is now visible.</item>
		/// </list</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnVisibilityChanged;

		/// <summary>
		/// <para>Fired when the visibility of a column has changed. This event is equal to
		/// &#8220;visibilityChanged&#8221;, but is fired right before.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnVisibilityChangedPre;

		/// <summary>
		/// <para>Fired when the width of a column has changed. The data property of the event is
		/// a map having the following attributes:
		/// <list type="bullet">
		/// <item>col: The model index of the column the width of which has changed.</item>
		/// <item>newWidth: The new width of the column in pixels.</item>
		/// <item>oldWidth: The old width of the column in pixels.</item>
		/// </list</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnWidthChanged;

		#endregion Events

		#region Methods

		public Basic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the cell editor factory of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <returns>the cell editor factory of the column.</returns>
		[JsMethod(Name = "getCellEditorFactory")]
		public qx.ui.table.ICellEditorFactory GetCellEditorFactory(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the width of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <returns>the width of the column in pixels.</returns>
		[JsMethod(Name = "getColumnWidth")]
		public double GetColumnWidth(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the data renderer of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <returns>the data renderer of the column.</returns>
		[JsMethod(Name = "getDataCellRenderer")]
		public qx.ui.table.ICellRenderer GetDataCellRenderer(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the header renderer of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <returns>the header renderer of the column.</returns>
		[JsMethod(Name = "getHeaderCellRenderer")]
		public qx.ui.table.IHeaderRenderer GetHeaderCellRenderer(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the model index of a column at a certain overall x position.</para>
		/// </summary>
		/// <param name="overXPos">the overall x position of the column.</param>
		/// <returns>the model index of the column.</returns>
		[JsMethod(Name = "getOverallColumnAtX")]
		public double GetOverallColumnAtX(double overXPos) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the overall number of columns (including hidden columns).</para>
		/// </summary>
		/// <returns>the overall number of columns.</returns>
		[JsMethod(Name = "getOverallColumnCount")]
		public double GetOverallColumnCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the overall x position of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <returns>the overall x position of the column.</returns>
		[JsMethod(Name = "getOverallX")]
		public double GetOverallX(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the model index of a column at a certain visible x position.</para>
		/// </summary>
		/// <param name="visXPos">the visible x position of the column.</param>
		/// <returns>the model index of the column.</returns>
		[JsMethod(Name = "getVisibleColumnAtX")]
		public double GetVisibleColumnAtX(double visXPos) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the number of visible columns.</para>
		/// </summary>
		/// <returns>the number of visible columns.</returns>
		[JsMethod(Name = "getVisibleColumnCount")]
		public double GetVisibleColumnCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the array of visible columns</para>
		/// </summary>
		/// <returns>List of all visible columns</returns>
		[JsMethod(Name = "getVisibleColumns")]
		public JsArray GetVisibleColumns() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the visible x position of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <returns>the visible x position of the column.</returns>
		[JsMethod(Name = "getVisibleX")]
		public double GetVisibleX(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Initializes the column model.</para>
		/// </summary>
		/// <param name="colCount">The number of columns the model should have.</param>
		/// <param name="table">The table to which this column model is attached.</param>
		[JsMethod(Name = "init")]
		public void Init(double colCount, qx.ui.table.Table table) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether a certain column is visible.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <returns>whether the column is visible.</returns>
		[JsMethod(Name = "isColumnVisible")]
		public bool IsColumnVisible(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Moves a column.</para>
		/// </summary>
		/// <param name="fromOverXPos">the overall x position of the column to move.</param>
		/// <param name="toOverXPos">the overall x position of where the column should be moved to.</param>
		[JsMethod(Name = "moveColumn")]
		public void MoveColumn(double fromOverXPos, double toOverXPos) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the cell editor factory of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <param name="factory">the new cell editor factory the column should get.</param>
		[JsMethod(Name = "setCellEditorFactory")]
		public void SetCellEditorFactory(double col, qx.ui.table.ICellEditorFactory factory) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Reorders all columns to new overall positions. Will fire one &#8220;orderChanged&#8221; event
		/// without data afterwards</para>
		/// </summary>
		/// <param name="newPositions">Array mapping the index of a column in table model to its wanted overall position on screen (both zero based). If the table models holds col0, col1, col2 and col3 and you give [1,3,2,0], the new column order will be col3, col0, col2, col1</param>
		[JsMethod(Name = "setColumnsOrder")]
		public void SetColumnsOrder(double newPositions) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets whether a certain column is visible.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <param name="visible">whether the column should be visible.</param>
		[JsMethod(Name = "setColumnVisible")]
		public void SetColumnVisible(double col, bool visible) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the width of a column.</para>
		/// </summary>
		/// <param name="col">The model index of the column.</param>
		/// <param name="width">The new width the column should get in pixels.</param>
		/// <param name="isMouseAction">true if the column width is being changed as a result of a mouse drag in the header; false or undefined otherwise.</param>
		[JsMethod(Name = "setColumnWidth")]
		public void SetColumnWidth(double col, double width, bool isMouseAction) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the data renderer of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <param name="renderer">the new data renderer the column should get.</param>
		/// <returns>If an old renderer was set and it was not the default renderer, the old renderer is returned for pooling or disposing.</returns>
		[JsMethod(Name = "setDataCellRenderer")]
		public qx.ui.table.ICellRenderer SetDataCellRenderer(double col, qx.ui.table.ICellRenderer renderer) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the header renderer of a column.</para>
		/// </summary>
		/// <param name="col">the model index of the column.</param>
		/// <param name="renderer">the new header renderer the column should get.</param>
		[JsMethod(Name = "setHeaderCellRenderer")]
		public void SetHeaderCellRenderer(double col, qx.ui.table.IHeaderRenderer renderer) { throw new NotImplementedException(); }

		#endregion Methods
    }
}