using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class ContactsPage : ContentPage
	{
		//public ListView ListView { get { return listView; } }

		public ContactsPage()
		{
			InitializeComponent();

			var ProductItems = new List<ProductDetailModel>();

			ProductItems.AddRange(Global.iniProducts());

			var grid = new Grid();
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(200) });
			grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });
			var images = new List<Image>();

			int tmp = 0;
			foreach (var p in ProductItems)
			{
				var i = ProductItems.IndexOf(p);

				var img = new Image
				{
					Source = p.imgName
				};

				grid.Children.Add(img, 0, i);
				if (i >= 3)
				{
					grid.Children.Add(img, 1, tmp);
					tmp++;
				}

				TapGestureRecognizer tap = new TapGestureRecognizer();
				tap.Tapped += async (object sender, EventArgs e) =>
				{
					await OnImageNameTapped(sender, e, p);
				};

				img.GestureRecognizers.Add(tap);
			}

			Content = grid;
		}

		public async Task OnImageNameTapped(object sender, EventArgs args,ProductDetailModel p)
		{
			try
			{
				var masterDetail = App.Current.MainPage as MasterDetailPage;

				if (masterDetail == null || masterDetail.Detail == null)
				{
					return;
				}
				
				var navigationPage = masterDetail.Detail as NavigationPage;

				if (navigationPage == null)
				{
					masterDetail.Detail = new NavigationPage(new ProductDetailPage(p));
					masterDetail.IsPresented = false;
					return;
				}

				await navigationPage.Navigation.PushAsync(new ProductDetailPage(p));

				masterDetail.IsPresented = false;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
