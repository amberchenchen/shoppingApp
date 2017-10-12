using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using System.Linq;

namespace MasterDetailPageNavigation
{
	public partial class ProductDetailPage : ContentPage
	{

		public ProductDetailPage(ProductDetailModel vm)
		{
			InitializeComponent();

			BindingContext = vm;
		}
	}
}
