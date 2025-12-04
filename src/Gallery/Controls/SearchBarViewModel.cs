using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gallery.Controls;

public sealed partial class SearchBarViewModel
    : BaseViewModel
{
    private readonly IReadOnlyList<string> _words =
    [
        ".NET",
        "C#",
        "Cross-Platform",
        "MAUI",
        "User Interface",
        "SearchBar"
    ];

    [ObservableProperty]
    private string _filterText = string.Empty;

    [ObservableProperty]
    private ObservableCollection<string> _items = [];

    public void Load()
    {
        Items.Clear();
        foreach (var word in _words)
        {
            Items.Add(word);
        }
    }

    [RelayCommand]
    private void FilterBy(string filterText)
    {
        Items.Clear();

        Items = [.. _words.Where(w => w.Contains(filterText))];
    }
}