using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp7.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel() { }

    [ObservableProperty]
    string text;

    [RelayCommand] 
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync( $"{nameof(DetailPage)}?Text={s}");
    }

}
