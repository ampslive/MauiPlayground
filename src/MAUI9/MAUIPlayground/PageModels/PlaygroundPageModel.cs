using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIPlayground.Models;

namespace MAUIPlayground.PageModels;

public partial class PlaygroundPageModel : ObservableObject
{
    [ObservableProperty]
    private List<Item> _items = [];
    public PlaygroundPageModel()
    {

    }

    [RelayCommand]
    private async Task Appearing()
    {
       await InitData();
    }

    private async Task InitData()
    {
        Items = new List<Item>
        {
            new() {
                Title = "Item 1",
                Description = "Description 1",
                Image = "https://imageplaceholder.net/600x400/bbbeee"
            },
            new ()
            {
                Title = "Item 2",
                Description = "Description 2",
                Image = "Green"
            },
            new ()
            {
                Title = "Item 3",
                Description = "Description 3",
                Image = "Orange"
            },
            new ()
            {
                Title = "Item 4",
                Description = "Description 4",
                Image = "Blue"
            },
        };
    }
}


