using System;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;

namespace MVC_og_LinQ;

internal class Controller
{

    List<Digimon> HighHP = new();
     internal void OverThousand(List<Digimon> digimons)
    {
        
            HighHP = digimons.Where(d => d.Lv50HP > 1000).ToList();
            
            foreach (var d in HighHP)
            {
            Console.WriteLine($" {d.Name}: {d.Stage} ");
            }
    }

    internal void ShowStageDistribution(List<Digimon> digimons)
    {
        var groupedData = digimons.GroupBy(d => d.Stage);
        Console.WriteLine("--- Digimoun Count by Stage ---");

        foreach (var group in groupedData)
        {
            // group.Key is the name of the stage (e.g., "Rookie", "Mega")
            // group.Count() tells us how many Digimon are in this specific group
            Console.WriteLine($"{group.Key.PadRight(15)} : {group.Count().ToString().PadRight(5)} Digimon");
        }
    }

    internal void Descending(List<Digimon> digimons)
    {
        var sorted = digimons
                    .GroupBy(d => d.Stage)
                    .OrderByDescending(g => g.Count());

        foreach (var g in sorted)
        {
            Console.WriteLine($"{g.Key.PadRight(15)} : {g.Count().ToString().PadRight(5)} Digimon");
        }
    }

    internal void SortByUserChoice(List<Digimon> digimons, string choice)
    {
        IEnumerable<Digimon> sortedList = choice.ToLower() switch
        {
          "hp"  =>  digimons.OrderByDescending(d => d.Lv50HP),
          "atk" =>  digimons.OrderByDescending(d => d.Lv50ATK),
          "name"=>  digimons.OrderBy(d => d.Name),
          _     =>  digimons.OrderBy(d => d.Number)  
        };

    // If the default case was hit, you might still want a message
    if (choice.ToLower() is not "hp" and not "atk" and not "name")
    {
        Console.WriteLine("Invalid choice, sorting by Number instead.");
    }

    Console.WriteLine($"\n--- Sorted by {choice.ToUpper()} ---"); 
    foreach (var d in sortedList.Take(10)) 
    {
        Console.WriteLine($"{d.Name,-15} | HP: {d.Lv50HP} | ATK: {d.Lv50ATK}");
    }    

    }
}