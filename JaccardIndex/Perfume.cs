using System;
using System.Collections.Generic;

public class Perfume
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Name { get; set; }
    public List<string> Accords { get; set; }
    public Dictionary<Season, int> SeasonVotes { get; set; }
    public Dictionary<Day, int> DayVotes { get; set; }
    public string DayPeriod { get; set; }
    public List<string> Seasons { get; set; }
    public List<string> Notes { get; set; }

    public Perfume(
        int id,
        string brand,
        string name,
        List<string> accords,
        Dictionary<Season, int> seasons,
        Dictionary<Day, int> day,
        List<string> notes)
    {
        Id = id;
        Brand = brand;
        Name = name;
        Accords = accords;
        SeasonVotes = seasons;
        DayVotes = day;
        Notes = notes;

        DayPeriod = GetDay();
        Seasons = new List<string>();

        GetSeasons();
    }

    public string GetDay()
    {
        return DayVotes[Day.Day] > DayVotes[Day.Night]
            ? "Day"
            : "Night";
    }

    public void GetSeasons()
    {
        int maxVotes = 0;

        foreach (int votes in SeasonVotes.Values)
        {
            if (votes > maxVotes)
                maxVotes = votes;
        }

        double threshold = maxVotes * 0.75;

        foreach (var season in SeasonVotes)
        {
            if (season.Value > threshold)
                Seasons.Add(season.Key.ToString());
        }
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("\nAccords:");
        Console.WriteLine(string.Join("\n", Accords));

        Console.WriteLine($"\nDay: {DayPeriod}");
        Console.WriteLine("Season:");
        Console.WriteLine(string.Join("\n", Seasons));

        Console.WriteLine("\nNotes:");
        Console.WriteLine(string.Join("\n", Notes));
    }
}