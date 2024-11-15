namespace CondeRiera_TallerEnClaseMaui;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}

    private void IrFlexPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayoutPage());
    }
}