﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp7.ViewModel;

public partial class MainViewModel: ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>(); 
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(text))
            return;
        Items.Add(text);
        // Add our item
        Text = string.Empty;
    }
    [RelayCommand]
    void Delete(string s)
    {
        if(Items.Contains(s)){
            Items.Remove(s);
        }
    }

}
