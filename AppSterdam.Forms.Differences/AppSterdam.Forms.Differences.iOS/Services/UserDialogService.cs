using System;
using AppSterdam.Forms.Differences.iOS.Services;
using AppSterdam.Forms.Differences.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(UserDialogService))]
namespace AppSterdam.Forms.Differences.iOS.Services
{

	public class UserDialogService : IUserDialogService
	{
		public void Alert(string message, string title = null, string okText = "OK")
		{
			UIAlertView alert = new UIAlertView(message, title, null, "Ok", null);
			alert.Show();
		}
	}
}