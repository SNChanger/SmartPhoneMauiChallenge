namespace SmartPhoneMauiChallenge;

public partial class ReviewData : ContentPage
{
	public ReviewData()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }

    private void OnTargetBirthDayEditorTextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void OnTargetBirthDayEditorCompleted(object sender, EventArgs e)
    {

    }

    private void OnBuyAccountEditorCompleted(object sender, EventArgs e)
    {

    }

    private void OnBuyAccountNameEditorTextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void OnSaleHospitalEditorCompleted(object sender, EventArgs e)
    {

    }

    private void OnSaleHospitalNameEditorTextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void OnStoreNameEditorCompleted(object sender, EventArgs e)
    {

    }

    private void OnStoreNameEditorTextChanged(object sender, TextChangedEventArgs e)
    {

    }
}