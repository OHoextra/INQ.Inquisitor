using Inquisitor.Pages;

namespace Inquisitor;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new HomePage());
    }
}
