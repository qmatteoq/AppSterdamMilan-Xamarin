using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSterdam.Forms.Differences.Services;
using Xamarin.Forms;

namespace AppSterdam.Forms.Differences.Views
{
	public partial class MainView : ContentPage
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void OnShowAlertClicked(object sender, EventArgs e)
		{
			IUserDialogService userDialogService = DependencyService.Get<IUserDialogService>();
			userDialogService.Alert("This is an alert message", "Alert");
		}
	}
}


