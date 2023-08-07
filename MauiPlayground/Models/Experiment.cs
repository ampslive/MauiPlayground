namespace MauiPlayground.Models;

public class Experiment
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Thumbnail { get; set; }
    public string Type { get; set; }
    public string PageUri { get; set; }

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
