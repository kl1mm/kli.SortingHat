namespace kli.SortingHat.Models;

public class House
{
    public static readonly House Gryffindor = new(nameof(Gryffindor), "images/gryffindor.webp", "sounds/griffindor.wav");
    public static readonly House Slytherin = new(nameof(Slytherin), "images/slytherin.webp", "sounds/slitherin.wav");
    public static readonly House Ravenclaw = new(nameof(Ravenclaw), "images/ravenclaw.webp", "sounds/ravenclaw.wav");
    public static readonly House Hufflepuff = new(nameof(Hufflepuff), "images/hufflepuff.webp", "sounds/huffelpuff.wav");
    public static IReadOnlyList<House> All { get; } = new[] { Gryffindor, Slytherin, Ravenclaw, Hufflepuff };

    public string Id { get; }
    public string Name { get; }
    public string ImageSrc { get; }
    public string SoundSrc { get; }

    public House(string name, string imageSrc, string soundSrc)
    {
        Id = name.ToLowerInvariant();
        Name = name;
        ImageSrc = imageSrc;
        SoundSrc = soundSrc;
    }
}