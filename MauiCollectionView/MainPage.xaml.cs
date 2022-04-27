using MauiCollectionView.Models;

namespace MauiCollectionView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var botSelected = ((TappedEventArgs)e).Parameter as Bot;
        var bots = ((MainPageViewModel)BindingContext).Bots;
        foreach (var bot in bots)
        {
            bot.IsSelected = false;
        }
        botSelected.IsSelected = true;
    }
}