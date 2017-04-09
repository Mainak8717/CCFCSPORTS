using Xamarin.Forms;

namespace CCFCSPORTS
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new CCFCSPORTSPage();

			MainPage = new NavigationPage(new CCFCSPORTSPage())
			{
				BarBackgroundColor = Color.Red,
				BarTextColor = Color.White,
				Title ="Admin Login"
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
