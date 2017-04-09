using Xamarin.Forms;

namespace CCFCSPORTS
{
	public partial class CCFCSPORTSPage : ContentPage
	{
		public CCFCSPORTSPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
		}

		void SkipBtn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new CCFCSPORTSHomePage());
		}
		void LoginBtn_Clicked(object sender, System.EventArgs e)
		{
		}
	}
}
