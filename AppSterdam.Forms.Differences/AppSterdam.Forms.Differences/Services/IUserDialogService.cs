namespace AppSterdam.Forms.Differences.Services
{

	public interface IUserDialogService
	{
		void Alert(string message, string title = null, string okText = "OK");

	}
}