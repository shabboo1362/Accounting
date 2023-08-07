using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace RamiSaad
{
	/// <summary>
	/// Summary description for DataGridButtonColumn.
	/// This class builds the Button column user control for datagrids for windows application. 
	/// It inherits DataGridTextBoxColumn, since this is already an available control in the .Net Framework.
	/// What needs to be modified, depending on the application, is the ValueChanged event. 
	/// To use this class, simply add it to the project, construct an instance, and use its properties
	/// this is a sample usage:
	/// 
	///	DataGridButtonColumn col4=new DataGridButtonColumn(10);
	///	col4.HeaderText="Text";
	///	col4.MappingName="Name";
	/// //hookup our cellbutton handler...
	///	col4.CellButtonClicked += 
	///	new DataGridCellButtonClickEventHandler(HandleCellButtonClick);
	///	style.GridColumnStyles.Add(col4);
	///	//hook the mouse handlers
	///	dataGrid1.MouseDown += new MouseEventHandler(col4.HandleMouseDown);
	///	dataGrid1.MouseUp += new MouseEventHandler(col4.HandleMouseUp);
	///	
	///	Trick is that you have to mention thecolumn number when creating an instance
	///	of the class, because the event handlers depend on the position of the cell
	///	
	/// </summary>

	public class DataGridButtonColumn : DataGridTextBoxColumn
	{
		public event DataGridCellButtonClickEventHandler CellButtonClicked;

		private Bitmap _button;
		private Bitmap _buttonPressed;
		private int _columnNum;
		private int _pressedRow;

		public DataGridButtonColumn(int colNum)
		{
			_columnNum = colNum;
			_pressedRow = -1;

			//you will need to change the Assembly name in GetManifestResourceStream()
			try
			{
				char[] c={','};
				System.IO.Stream strm = this.GetType().Assembly.GetManifestResourceStream(this.GetType().Assembly.ToString().Split(c,10)[0]+".button.bmp");
				_button = new Bitmap(strm);
				strm = this.GetType().Assembly.GetManifestResourceStream(this.GetType().Assembly.ToString().Split(c,10)[0]+".buttonpressed.bmp");
				_buttonPressed = new Bitmap(strm);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		protected override void Edit(System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible) 
		{ 
			// dont call the baseclass so no editing done...
			//	base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible); 
		} 

		private void DrawButton(Graphics g, Bitmap bm, Rectangle bounds, int row)
		{

			DataGrid dg = this.DataGridTableStyle.DataGrid;
			string s = dg[row, this._columnNum].ToString();

			SizeF sz = g.MeasureString(s, dg.Font, bounds.Width - 4, StringFormat.GenericTypographic);

			int x = bounds.Left + Math.Max(0, (bounds.Width - (int)sz.Width)/2);
			g.DrawImage(bm, bounds, 0, 0, bm.Width, bm.Height,GraphicsUnit.Pixel);
			
			if(sz.Height < bounds.Height)
			{
				int y = bounds.Top + (bounds.Height - (int) sz.Height) / 2;
				if(_buttonPressed == bm)
				{
					x++;
				}

				g.DrawString(s, dg.Font, new SolidBrush(dg.ForeColor), x, y);
			}

		}

		public void HandleMouseUp(object sender, MouseEventArgs e)
		{
			DataGrid dg = this.DataGridTableStyle.DataGrid;
			DataGrid.HitTestInfo hti = dg.HitTest(new Point(e.X, e.Y));
			bool isClickInCell = (hti.Column == this._columnNum
				&& hti.Row > -1);

			_pressedRow = -1;

			Rectangle rect = new Rectangle(0,0,0,0);

			if(isClickInCell)
			{
				rect = dg.GetCellBounds(hti.Row, hti.Column);
				isClickInCell = (e.X > rect.Right - this._button.Width);
			}
			if(isClickInCell)
			{
				Graphics g = Graphics.FromHwnd(dg.Handle);
				//	g.DrawImage(this._button, rect.Right - this._button.Width, rect.Y);
				DrawButton(g, this._button, rect, hti.Row);
				g.Dispose();
				if(CellButtonClicked != null)
					CellButtonClicked(this, new DataGridCellButtonClickEventArgs(hti.Row, hti.Column));
			}
		}

		public void HandleMouseDown(object sender, MouseEventArgs e)
		{
			DataGrid dg = this.DataGridTableStyle.DataGrid;
			DataGrid.HitTestInfo hti = dg.HitTest(new Point(e.X, e.Y));
			bool isClickInCell = (hti.Column == this._columnNum
				&& hti.Row > -1);

			Rectangle rect = new Rectangle(0,0,0,0);
			if(isClickInCell)
			{
				rect = dg.GetCellBounds(hti.Row, hti.Column);
				isClickInCell = (e.X > rect.Right - this._button.Width);
			}

			if(isClickInCell)
			{
				//Console.WriteLine("HandleMouseDown " + hti.Row.ToString());
				Graphics g = Graphics.FromHwnd(dg.Handle);
				//g.DrawImage(this._buttonPressed, rect.Right - this._buttonPressed.Width, rect.Y);
				DrawButton(g, _buttonPressed, rect, hti.Row);
				g.Dispose();
				_pressedRow = hti.Row;
			}
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
		{
			//base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
	
			DataGrid parent = this.DataGridTableStyle.DataGrid;
			bool current = parent.IsSelected(rowNum) ||
				( parent.CurrentRowIndex == rowNum && 
				parent.CurrentCell.ColumnNumber == this._columnNum);

			
		
			//draw the button
			Bitmap bm = _pressedRow == rowNum ? this._buttonPressed : this._button;
			this.DrawButton(g, bm, bounds, rowNum);
			
			//font.Dispose();
		
		}
	
	
	}

	public delegate void DataGridCellButtonClickEventHandler(object sender, DataGridCellButtonClickEventArgs e);

	public class DataGridCellButtonClickEventArgs : EventArgs
	{
		private int _row;
		private int _col;

		public DataGridCellButtonClickEventArgs(int row, int col)
		{
			_row = row;
			_col = col;
		}

		public int RowIndex	{get{return _row;}}
		public int ColIndex	{get{return _col;}}
	}

}
