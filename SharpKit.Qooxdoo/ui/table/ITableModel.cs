// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table
{
    /// <summary>
	/// <para>The data model of a table.</para>
	/// </summary>
	public interface ITableModel
    {
		#region Events

		/// <summary>
		/// <para>Fired when the table data changed (the stuff shown in the table body).
		/// The data property of the event may be null or a map having the following attributes:
		/// <list type="bullet">
		/// <item>firstRow: The index of the first row that has changed.</item>
		/// <item>lastRow: The index of the last row that has changed.</item>
		/// <item>firstColumn: The model index of the first column that has changed.</item>
		/// <item>lastColumn: The model index of the last column that has changed.</item>
		/// </list</para>
		/// </summary>
		event Action<qx.eventx.type.Data> OnDataChanged;

		/// <summary>
		/// <para>Fired when the meta data changed (the stuff shown in the table header).</para>
		/// </summary>
		event Action<qx.eventx.type.Event> OnMetaDataChanged;

		/// <summary>
		/// <para>Fired after the table is sorted (but before the metaDataChanged event)</para>
		/// </summary>
		event Action<qx.eventx.type.Data> OnSorted;

		#endregion Events

		#region Methods

		/// <summary>
		/// <para>Returns the number of columns in the model.</para>
		/// </summary>
		/// <returns>the number of columns.</returns>
		double GetColumnCount();

		/// <summary>
		/// <para>Returns the ID of column. The ID may be used to identify columns
		/// independent from their index in the model. E.g. for being aware of added
		/// columns when saving the width of a column.</para>
		/// </summary>
		/// <param name="columnIndex">the index of the column.</param>
		/// <returns>the ID of the column.</returns>
		string GetColumnId(double columnIndex);

		/// <summary>
		/// <para>Returns the index of a column.</para>
		/// </summary>
		/// <param name="columnId">the ID of the column.</param>
		/// <returns>the index of the column.</returns>
		double GetColumnIndexById(string columnId);

		/// <summary>
		/// <para>Returns the name of a column. This name will be shown to the user in the
		/// table header.</para>
		/// </summary>
		/// <param name="columnIndex">the index of the column.</param>
		/// <returns>the name of the column.</returns>
		string GetColumnName(double columnIndex);

		/// <summary>
		/// <para>Returns the number of rows in the model.</para>
		/// </summary>
		/// <returns>the number of rows.</returns>
		double GetRowCount();

		/// <summary>
		/// <para>Returns the data of one row. This function may be overridden by models which hold
		/// all data of a row in one object. By using this function, clients have a way of
		/// quickly retrieving the entire row data.</para>
		/// Important:Models which do not have their row data accessible in one object
		/// may return null.
		/// </summary>
		/// <param name="rowIndex">the model index of the row.</param>
		/// <returns>the row data as an object or null if the model does not support row data objects. The details on the object returned are determined by the model implementation only.</returns>
		object GetRowData(double rowIndex);

		/// <summary>
		/// <para>Returns the column index the model is sorted by. If the model is not sorted
		/// -1 is returned.</para>
		/// </summary>
		/// <returns>the column index the model is sorted by.</returns>
		double GetSortColumnIndex();

		/// <summary>
		/// <para>Returns a cell value by column index.</para>
		/// </summary>
		/// <param name="columnIndex">the index of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <returns>The value of the cell.</returns>
		object GetValue(double columnIndex, double rowIndex);

		/// <summary>
		/// <para>Returns a cell value by column ID.</para>
		/// <para>Whenever you have the choice, use <see cref="GetValue()"/> instead,
		/// because this should be faster.</para>
		/// </summary>
		/// <param name="columnId">the ID of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <returns>the value of the cell.</returns>
		object GetValueById(string columnId, double rowIndex);

		/// <summary>
		/// <para>Returns whether a column is editable.</para>
		/// </summary>
		/// <param name="columnIndex">the column to check.</param>
		/// <returns>whether the column is editable.</returns>
		bool IsColumnEditable(double columnIndex);

		/// <summary>
		/// <para>Returns whether a column is sortable.</para>
		/// </summary>
		/// <param name="columnIndex">the column to check.</param>
		/// <returns>whether the column is sortable.</returns>
		bool IsColumnSortable(double columnIndex);

		/// <summary>
		/// <para>Returns whether the model is sorted ascending.</para>
		/// </summary>
		/// <returns>whether the model is sorted ascending.</returns>
		bool IsSortAscending();

		/// <summary>
		/// <para>Prefetches some rows. This is a hint to the model that the specified rows
		/// will be read soon.</para>
		/// </summary>
		/// <param name="firstRowIndex">the index of first row.</param>
		/// <param name="lastRowIndex">the index of last row.</param>
		void PrefetchRows(double firstRowIndex, double lastRowIndex);

		/// <summary>
		/// <para>Sets a cell value by column index.</para>
		/// </summary>
		/// <param name="columnIndex">The index of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <param name="value">The new value.</param>
		void SetValue(double columnIndex, double rowIndex, object value);

		/// <summary>
		/// <para>Sets a cell value by column ID.</para>
		/// <para>Whenever you have the choice, use <see cref="SetValue()"/> instead,
		/// because this should be faster.</para>
		/// </summary>
		/// <param name="columnId">The ID of the column.</param>
		/// <param name="rowIndex">The index of the row.</param>
		/// <param name="value">The new value.</param>
		void SetValueById(string columnId, double rowIndex, object value);

		/// <summary>
		/// <para>Sorts the model by a column.</para>
		/// </summary>
		/// <param name="columnIndex">the column to sort by.</param>
		/// <param name="ascending">whether to sort ascending.</param>
		void SortByColumn(double columnIndex, bool ascending);

		#endregion Methods
    }
}