namespace CondeRiera_TallerEnClaseMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void IrGridPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayoutPage());
        }
    }

}
