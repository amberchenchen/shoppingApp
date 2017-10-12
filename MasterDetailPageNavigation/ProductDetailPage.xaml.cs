using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class ProductDetailPage : ContentPage
	{

		public ProductDetailPage(string Id)
		{
			var vm = new ProductDetailModel();

			switch (Id)
			{
				case "1":
					vm.imgName = "iphone5s.jpg";
					vm.productName = "Iphone5s";
					vm.productDesc = "Iphone5s";
					break;

				case "2":
					vm.imgName = "iphone7.jpg";
					vm.productName = "iphone7";
					vm.productDesc = "iphone7";
					break;
					
				case "3":
					vm.imgName = "macPro.jpg";
					vm.productName = "macPro";
					vm.productDesc = "Mac Pro";
					break;

				case "4":
					vm.imgName = "macAir.jpg";
					vm.productName = "macAir";
					vm.productDesc = "Mac Air";
					break;
					
				case "5":
					vm.imgName = "aw42.jpg";
					vm.productName = "Apple Watch";
					vm.productDesc = "Apple Watch";
					break;

				case "6":
					vm.imgName = "awS.jpg";
					vm.productName = "Apple Watch";
					vm.productDesc = "Apple Watch";
					break;
			}

			InitializeComponent();

			vm.Id = Id;
			BindingContext = vm;
		}


		public void addToCart(object sender, EventArgs args)
		{
			var btnSender = (Button)sender;

			if (Global.imgs.Contains(btnSender.ClassId))
			{
				DisplayAlert("Alert", "This product is already in shopping cart!", "OK");
			}
			else
			{
				Global.imgs.Add(btnSender.ClassId);
			}

			var items = App.Current.MainPage.ToolbarItems;

			items[1].Text = Global.imgs.Count.ToString();
		}
	}
}
