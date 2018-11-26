using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindingWithPoco
{
	public class Product : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private int _ProductID;
		public int ProductID
		{
			get { return _ProductID; }
			set
			{
				_ProductID = value;
				OnPropertyChanged("ProductID");
			}
		}
		private string _ProductName;
		public string ProductName
		{
			get { return _ProductName; }
			set
			{
				_ProductName = value;
				OnPropertyChanged("ProductName");
			}
		}
		private int _SupplierID;
		public int SupplierID
		{
			get { return _SupplierID; }
			set
			{
				_SupplierID = value;
				OnPropertyChanged("SupplierID");
			}
		}
		private int _CategoryID;
		public int CategoryID
		{
			get { return _CategoryID; }
			set
			{
				_CategoryID = value;
				OnPropertyChanged("CategoryID");
			}
		}
		private string _QuantityPerUnit;
		public string QuantityPerUnit
		{
			get { return _QuantityPerUnit; }
			set
			{
				_QuantityPerUnit = value;
				OnPropertyChanged("QuantityPerUnit");
			}
		}
		private decimal _UnitPrice;
		public decimal UnitPrice
		{
			get { return _UnitPrice; }
			set
			{
				_UnitPrice = value;
				OnPropertyChanged("UnitPrice");
			}
		}
		private short _UnitsInStock;
		public short UnitsInStock
		{
			get { return _UnitsInStock; }
			set
			{
				_UnitsInStock = value;
				OnPropertyChanged("UnitsInStock");
			}
		}
		private short _UnitsOnOrder;
		public short UnitsOnOrder
		{
			get { return _UnitsOnOrder; }
			set
			{
				_UnitsOnOrder = value;
				OnPropertyChanged("UnitsOnOrder");
			}
		}
		private short _ReorderLevel;
		public short ReorderLevel
		{
			get { return _ReorderLevel; }
			set
			{
				_ReorderLevel = value;
				OnPropertyChanged("ReorderLevel");
			}
		}
		private bool _Discontinued;
		public bool Discontinued
		{
			get { return _Discontinued; }
			set
			{
				_Discontinued = value;
				OnPropertyChanged("Discontinued");
			}
		}
     

	}
}


