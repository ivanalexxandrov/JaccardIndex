using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

class Program
{
    public static List<Perfume> Catalogue = PerfumeData.catalogue;
    public static void ComparePerfumes(string name)
    {
        Perfume? target = Catalogue.FirstOrDefault(p => p.Name == name);
        Console.WriteLine($"\n\n\nPerfumes similair to: {name}");
        var selected = Catalogue
            .Where(p => p.Name != target.Name)
            .Select(perf => new
            {
                Perfume = perf,
                Score = new Comparison(perf, target).result
            })
            .OrderByDescending(x => x.Score)
            .Take(5);

        foreach (var item in selected)
        {
            Console.WriteLine($"{item.Perfume.Name} - {item.Score:P2}");
        }
    }
    public static string PerfumeInputValidation()
    {
        string input;
        do
        {
            input = Console.ReadLine();
        }
        while (!Catalogue.Any(p => p.Name == input));
        return input;
    }
    static void Main(string[] args)
    {
        PerfumeData.FillData();
        Catalogue = PerfumeData.catalogue;
        //whiteHero.Display();
        //Catalogue[2].Display();
        //Catalogue[3].Display();

        //Comparison c1 = new Comparison(Catalogue[2], Catalogue[3]);
        //Console.WriteLine(c1.displayPercent);

        Console.WriteLine("\n\n\nAvailable perfumes:");
        foreach (var perf in Catalogue)
        {
            Console.WriteLine(perf.Name);
        }
        Console.Write("\nPerfume: ");
        string perfumeName = PerfumeInputValidation();
        ComparePerfumes(perfumeName);
    }
    
}

