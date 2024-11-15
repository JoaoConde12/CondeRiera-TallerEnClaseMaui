namespace CondeRiera_TallerEnClaseMaui;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}

	private void IrStackPage(object sender, EventArgs e)
	{
        Navigation.PushAsync(new StackLayoutPage());
    }
}