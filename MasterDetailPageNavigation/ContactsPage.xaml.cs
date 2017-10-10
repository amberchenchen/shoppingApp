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
			ProductItems.Add(new ProductDetailModel
			{
				Id = "1",
				imgName = "iphone5s.jpg",
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "2",
				imgName = "iphone7.jpg",
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "3",
				imgName = "macPro.jpg",
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "4",
				imgName = "macAir.jpg",
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "5",
				imgName = "aw42.jpg",
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "6",
				imgName = "awS.jpg",
			});

			var grid = new Grid();
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
			grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(200) });
			grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });
			var images = new List<Image>();
			foreach (var p in ProductItems)
			{
				images.Add(new Image
				{
					Source = p.imgName,
					ClassId = p.Id
				});
			}

			int tmp = 0;
			for (var i = 0; i < images.Count; i++)
			{
				grid.Children.Add(images[i], 0, i);
				if (i >= 3)
				{
					grid.Children.Add(images[i], 1, tmp);
					tmp++;
				}

				TapGestureRecognizer tap = new TapGestureRecognizer();
				tap.Tapped += async (object sender, EventArgs e) =>
				{
					await OnImageNameTapped(sender,e);
				};
				images[i].GestureRecognizers.Add(tap);
			}

			Content = grid;


			//listView.ItemsSource = ProductItems;
			//img1.Source = "iphone5s.jpg";
			//img1.ClassId = "1";
		}

		public async Task OnImageNameTapped(object sender, EventArgs args)
		{
			var imageSender = (Image)sender;
			var Id = imageSender.ClassId;

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
					masterDetail.Detail = new NavigationPage(new ProductDetailPage(Id));
					masterDetail.IsPresented = false;
					return;
				}

				await navigationPage.Navigation.PushAsync(new ProductDetailPage(Id));

				masterDetail.IsPresented = false;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
