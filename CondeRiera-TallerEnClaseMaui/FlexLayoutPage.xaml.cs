namespace CondeRiera_TallerEnClaseMaui;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

    private async void OnImageTapped(object sender, EventArgs e)
    {
        // Navegaci�n a AbsoluteLayoutPage
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}