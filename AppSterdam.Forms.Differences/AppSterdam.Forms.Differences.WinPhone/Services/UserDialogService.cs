using System.Windows;
using AppSterdam.Forms.Differences.Services;
using AppSterdam.Forms.Differences.WinPhone.Services;

[assembly: Xamarin.Forms.Dependency(typeof(UserDialogService))]
namespace AppSterdam.Forms.Differences.WinPhone.Services
{

	public class UserDialogService : IUserDialogService
	{
		public void Alert(string message, string title = null, string okText = "OK")
		{
			MessageBox.Show(message, title, MessageBoxButton.OK);
		}
	}
}
