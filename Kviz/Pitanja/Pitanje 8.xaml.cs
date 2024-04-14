using Microsoft.Maui;

namespace Kviz.Pitanja;

public partial class Pitanje_8 : ContentPage
{
	public Pitanje_8()
	{
		InitializeComponent();
	}

    public void OnSubmitClicked(object sender, EventArgs e)
    {
        if (TextInput.Text.ToLower() == "joystick")
        {
            AnswerLabel.IsVisible = true;
            AnswerLabel.TextColor = Color.FromArgb("#00ff33");
            AnswerLabel.Text = "Točno!";
            SubmitBtn.Text = "Dalje";
            SubmitBtn.Clicked -= OnSubmitClicked;
            SubmitBtn.Clicked += OpenNext;
            TextInput.IsEnabled = false;
        }
        else
        {
            AnswerLabel.IsVisible = true;
            AnswerLabel.TextColor = Color.FromArgb("#ff0000");
            AnswerLabel.Text = "Netočno!";
        }
    }

    public void OpenNext(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pitanje_9());
    }
}