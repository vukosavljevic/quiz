using Microsoft.Maui.Controls;
namespace Kviz.Pitanja;

public partial class EndPage : ContentPage
{
	public EndPage()
	{
		InitializeComponent();
	}

	public void OnCloseClicked(object sender, EventArgs e)
	{
		Application.Current.Quit();
    }
}