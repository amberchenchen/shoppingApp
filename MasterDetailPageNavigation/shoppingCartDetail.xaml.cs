using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class shoppingCartDetail : ContentPage
	{
		ObservableCollection<ProductDetailModel> collection = new ObservableCollection<ProductDetailModel>(Global.imgs);
		public shoppingCartDetail()
		{
			InitializeComponent();

			listView.ItemsSource = collection;
		}

		private void removeItem(object sender, System.EventArgs e)
		{
			var item = ((Button)sender);
			var product = (ProductDetailModel)item.CommandParameter;
			Global.imgs.Remove(product);
			collection.Remove(product);

			var items = App.Current.MainPage.ToolbarItems;

			items[1].Text = Global.imgs.Count.ToString();
		}
	}
}
