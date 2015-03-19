using System;
using System.Threading;
using Android.App;
using AppSterdam.Forms.Differences.Droid.Services;
using AppSterdam.Forms.Differences.Services;
using Xamarin.Forms;
using Application = Android.App.Application;

[assembly: Dependency(typeof(UserDialogService))]


namespace AppSterdam.Forms.Differences.Droid.Services
{

	public class UserDialogService : IUserDialogService
	{
		public void Alert(string message, string title = null, string okText = "OK")
		{
			AlertDialog.Builder alert = new AlertDialog.Builder(Xamarin.Forms.Forms.Context);
			alert.SetTitle(title)
				.SetMessage(message)
				.SetPositiveButton("Ok", (sender, args) =>
				{

				})
				.Show();
		}
	}
}