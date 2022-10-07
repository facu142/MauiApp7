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

    [RelayCommand]
    async Task GoToLogin()
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }


}
