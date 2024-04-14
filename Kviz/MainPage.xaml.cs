using Kviz.Pitanja;

namespace Kviz;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnStartClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Pitanje1());
	}
}

