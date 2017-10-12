using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();

			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}

		public async Task openShoppingCartDetail()
		{
			var masterDetail = App.Current.MainPage as MasterDetailPage;

			if (masterDetail == null || masterDetail.Detail == null)
			{
				return;
			}

			var navigationPage = masterDetail.Detail as NavigationPage;

			if (navigationPage == null)
			{
				masterDetail.Detail = new NavigationPage(new shoppingCartDetail());
				masterDetail.IsPresented = false;
				return;
			}

			await navigationPage.Navigation.PushAsync(new shoppingCartDetail());

			masterDetail.IsPresented = false;
		}
	}
}
