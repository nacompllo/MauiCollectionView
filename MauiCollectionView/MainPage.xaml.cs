namespace MauiCollectionView;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}

    private void Editor_Completed(object sender, EventArgs e)
    {

    }
}