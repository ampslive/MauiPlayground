namespace MAUIPlayground.Pages;

public partial class Playground : ContentPage
{
	public Playground(PlaygroundPageModel model)
	{
		InitializeComponent();
        BindingContext = model;
    }
}