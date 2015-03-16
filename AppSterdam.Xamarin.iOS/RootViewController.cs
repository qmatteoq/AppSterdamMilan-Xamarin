using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using AppSterdam.Xamarin.Shared.Entities;
using AppSterdam.Xamarin.Shared.Services;
using Foundation;
using UIKit;

namespace AppSterdam.Xamarin.iOS
{
	public partial class RootViewController : UIViewController
	{
		public RootViewController(IntPtr handle) : base(handle)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();

			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}

		#endregion


		partial void btnGetNews_TouchUpInside (UIButton sender)
		{
			RssService service = new RssService();
			IEnumerable<FeedItem> items = await service.GetNews("http://feeds.feedburner.com/qmatteoq_eng");

			string message = string.Format("Number of news: {0}", items.Count());
			UIAlertView alert = new UIAlertView("News", message, null, "Ok", null);
			alert.Show();
		}
	}
}