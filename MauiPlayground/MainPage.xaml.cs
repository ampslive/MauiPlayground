using System.Collections.ObjectModel;

namespace MauiPlayground;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Experiment> Experiments;

	public MainPage()
	{
		InitializeComponent();

		this.Experiments = new ObservableCollection<Experiment>(); 

		Experiments.Add(new Experiment("UI Switcher", "Display and Hide features based on a particular value. This is using Bit Masking techniques.", "thumbnail", "type", "page"));
        BindingContext = new Experiment();
    }
}

public class Experiment
{
    public Guid Id { get; set; }
    public string Name { get; set; }
	public string Description { get; set; }
	public string Thumbnail { get; set; }
	public string Type { get; set; }
	public string PageUri { get; set; }

    public Experiment()
    {
        Id = Guid.NewGuid();
        Name = "Hi";
    }

    public Experiment(string name, string description, string thumbnail, string type, string pageUri)
    {
		Id = Guid.NewGuid();
		Name = name;
		Description = description;
		Thumbnail = thumbnail;
		Type = type;
		PageUri = pageUri;
    }
}