using MauiPlayground.Models;
using System.Collections.ObjectModel;

namespace MauiPlayground;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Experiment> Experiments = new ObservableCollection<Experiment>();

    public MainPage()
    {
        InitializeComponent();

        //Experiments.Add(new Experiment("UI Switcher", "Display and Hide features based on a particular value. This is using Bit Masking techniques.", "thumbnail", "type", "page"));
        BindingContext = Experiments;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Experiments.Add(new Experiment("UI Switcher", "Display and Hide features based on a particular value. This is using Bit Masking techniques.", "thumbnail", "type", "page"));
    }


}
    