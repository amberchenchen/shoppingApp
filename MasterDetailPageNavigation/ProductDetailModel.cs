using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class ProductDetailModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string _imgName;
		public string _productName;
		public string _productDesc;
		public string _Id;

		public String Id
		{
			get
			{
				return _Id;
			}
			set
			{
				_Id = value;
				OnPropertyChanged("Id");
			}
		}

		public String imgName
		{
			get
			{
				return _imgName;
			}
			set
			{
				_imgName = value;
				OnPropertyChanged("imgName");
			}
		}

		public string productName 
		{ 
			get
			{
				return _productName;
			}
			set
			{
				_productName = value;
				OnPropertyChanged("productName");
			}
		}

		public string productDesc 
		{ 
			get 
			{
				return _productDesc;
			}
			set
			{
				if (_productDesc != value)
				{
					_productDesc = value;
					this.OnPropertyChanged("productDesc");
				}
			}
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

