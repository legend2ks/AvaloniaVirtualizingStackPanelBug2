using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Avalonia.Controls.Selection;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaRC11_ListBug.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
    }

    [RelayCommand]
    private void RemoveButtonPressed()
    {
        Items.RemoveAt(Selection.SelectedIndex);
    }

    public ObservableCollection<string> Items { get; set; } = new()
    {
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven",
        "Eight",
        "Nine",
        "Ten",
        "Eleven",
        "Twelve",
        "Thirteen",
        "Fourteen",
        "Fifteen",
    };

    public SelectionModel<string> Selection { get; } = new()
    {
        SingleSelect = true
    };
}