namespace Kviz.Pitanja;

public partial class Pitanje_10 : ContentPage
{
	public Pitanje_10()
	{
		InitializeComponent();
	}

    public void OnSubmitClicked(object sender, EventArgs e)
    {
        if (TextInput.Text.ToLower() == "sedam" || TextInput.Text == "7")
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
        Navigation.PushAsync(new EndPage());
    }
}