using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AppSterdam.Xamarin.Shared.Entities;
using AppSterdam.Xamarin.Shared.Services;

namespace AppSterdam.Xamarin.Android
{
	[Activity(Label = "AppSterdam.Xamarin.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.MyButton);

			button.Click += async delegate
			{
				RssService service = new RssService();
				IEnumerable<FeedItem> items = await service.GetNews("http://feeds.feedburner.com/qmatteoq_eng");

				AlertDialog.Builder alert = new AlertDialog.Builder(this);
				alert.SetTitle("Rss feed");
				alert.SetMessage(string.Format("Number of news: {0}", items.Count()));
				alert.SetPositiveButton("Ok", (sender, args) => { });
				alert.SetNegativeButton("Cancel", (sender, args) => { });
				alert.Show();
			};
		}
	}
}

