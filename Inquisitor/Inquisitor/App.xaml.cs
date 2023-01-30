using Inquisitor.Pages;

namespace Inquisitor;

public partial class App : Microsoft.Maui.Controls.Application
{
	public App(Home_Page page)
	{
		InitializeComponent();

        MainPage = new NavigationPage(page);
    }
}
