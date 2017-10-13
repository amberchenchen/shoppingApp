using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;


namespace MasterDetailPageNavigation
{
	public class ProductDetailModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string _imgName;
		public string _productName;
		public string _productDesc;
		public string _Id;
		public string _price;

		public ICommand addToCart { get; }

		public ProductDetailModel()
		{
			this.addToCart = new Command(async () => await Add());
		}

		public async Task Add()
		{
			var product = new ProductDetailModel();
			product.imgName = imgName;
			product.Id = Id;
			product.productName = productName;
			product.productDesc = productDesc;

			if (Global.imgs.Where(i => i.Id.Equals(Id)).Count() > 0)
			{
				await Application.Current.MainPage.DisplayAlert("Alert", "This product is already in shopping cart!", "OK");
			}
			else
			{
				Global.imgs.Add(product);
			}
			var items = App.Current.MainPage.ToolbarItems;

			items[1].Text = Global.imgs.Count.ToString();
		}

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

		public string price
		{
			get
			{
				return _price;
			}
			set
			{
				if (_price != value)
				{
					_price = value;
					this.OnPropertyChanged("price");
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

