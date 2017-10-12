using System;
using System.Collections.Generic;

namespace MasterDetailPageNavigation
{
	public class Global
	{
		public static List<ProductDetailModel> imgs = new List<ProductDetailModel>();

		public static List<ProductDetailModel> ProductItems = new List<ProductDetailModel>();

		public static List<ProductDetailModel> iniProducts()
		{
			ProductItems.Add(new ProductDetailModel
			{
				Id = "1",
				imgName = "iphone5s.jpg",
				productName = "Iphone5s",
				productDesc = "Iphone5s"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "2",
				imgName = "iphone7.jpg",
				productName = "Iphone7",
				productDesc = "Iphone7"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "3",
				imgName = "macPro.jpg",
				productName = "Mac Pro",
				productDesc = "Mac Pro"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "4",
				imgName = "macAir.jpg",
				productName = "Mac Air",
				productDesc = "Mac Air"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "5",
				imgName = "aw42.jpg",
				productName = "Apple Watch",
				productDesc = "Apple Watch"
			});

			ProductItems.Add(new ProductDetailModel
			{
				Id = "6",
				imgName = "awS.jpg",
				productName = "Apple Watch",
				productDesc = "Apple Watch"
			});

			return ProductItems;
		}
	}
}
