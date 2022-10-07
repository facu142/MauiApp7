using MauiApp7.ViewModel;

namespace MauiApp7;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

}


//public partial class MainPage : ContentPage
//{
//    public MainPage()
//    {
//        InitializeComponent();
//        BindingContext = new MainViewModel();
//    }

//}


