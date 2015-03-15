using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AppSterdam.Xamarin.Shared.Entities;
using AppSterdam.Xamarin.Shared.Services;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace AppSterdam.Xamarin.WindowsPhone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

		private async void OnGetNewsClicked(object sender, RoutedEventArgs e)
		{
			RssService service = new RssService();
			IEnumerable<FeedItem> items = await service.GetNews("http://feeds.feedburner.com/qmatteoq_eng");
			string message = string.Format("Number of news: {0}", items.Count());
			MessageDialog dialog = new MessageDialog(message);
			await dialog.ShowAsync();
		}
	}
}
