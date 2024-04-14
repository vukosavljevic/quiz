namespace Kviz.Pitanja;

public partial class Pitanje1 : ContentPage
{
	public Pitanje1()
	{
		InitializeComponent();
	}

	public void OnSubmitClicked(object sender, EventArgs e)
	{
        if (RadioButton2.IsChecked)
        {
            AnswerLabel.IsVisible = true;
            AnswerLabel.TextColor = Color.FromArgb("#00ff33");
            AnswerLabel.Text = "Točno!";
            SubmitBtn.Text = "Dalje";
            SubmitBtn.Clicked -= OnSubmitClicked;
            SubmitBtn.Clicked += OpenNext;
            RadioButton3.IsEnabled = false;
            RadioButton2.IsEnabled = false;
            RadioButton1.IsEnabled = false;
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
		Navigation.PushAsync(new Pitanje_2());
	}
}