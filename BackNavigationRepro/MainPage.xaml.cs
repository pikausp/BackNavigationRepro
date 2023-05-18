namespace BackNavigationRepro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnNavigatorClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(NewPage1));
	}
}

