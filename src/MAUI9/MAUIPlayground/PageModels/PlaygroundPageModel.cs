using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
            }
        };
    }
}

public class Item
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
}
