using Inquisitor.Pages;

namespace Inquisitor;

public partial class App : Microsoft.Maui.Controls.Application
{
	public App(HomePage page)
	{
		InitializeComponent();

        MainPage = new NavigationPage(page);
    }
}
