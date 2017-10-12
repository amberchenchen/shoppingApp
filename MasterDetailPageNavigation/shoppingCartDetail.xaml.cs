using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class shoppingCartDetail : ContentPage
	{
		public shoppingCartDetail()
		{
			InitializeComponent();

			listView.ItemsSource = Global.imgs;
		}
	}
}
