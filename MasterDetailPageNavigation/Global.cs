using System;
using System.Collections.Generic;

namespace MasterDetailPageNavigation
{
	public class Global
	{
		public static List<ProductDetailModel> imgs = new List<ProductDetailModel>();


		public static List<ProductDetailModel> iniProducts()
		{
			var ProductItems = new List<ProductDetailModel>();

			ProductItems.Add(new ProductDetailModel
			{
				Id = "1",
				imgName = "iphone5s.jpg",
				productName = "Iphone5s",
				productDesc = "Iphone5s",
				price = "$17000"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "2",
				imgName = "iphone7.jpg",
				productName = "Iphone7",
				productDesc = "Iphone7",
				price = "$20000"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "3",
				imgName = "macPro.jpg",
				productName = "Mac Pro",
				productDesc = "Mac Pro",
				price = "$67000"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "4",
				imgName = "macAir.jpg",
				productName = "Mac Air",
				productDesc = "Mac Air",
				price = "$47000"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "5",
				imgName = "aw42.jpg",
				productName = "Apple Watch",
				productDesc = "Apple Watch",
				price = "$12000"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "6",
				imgName = "awS.jpg",
				productName = "Apple Watch",
				productDesc = "Apple Watch",
				price = "$13000"
			});

			return ProductItems;
		}
	}
}
