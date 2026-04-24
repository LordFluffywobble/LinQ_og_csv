using System.Runtime.InteropServices;

namespace MVC_og_LinQ;

class Program
{
    static void Main(string[] args)
    {
        Loader DigiLoad = new();
        Controller Control = new();
        
        List<Digimon> result = DigiLoad.LoadMethod();
        // Control.OverThousand(result);

        // Control.ShowStageDistribution(result);   
        // Control.Descending(result);

        Control.SelectedNames(result);

        Console.WriteLine("Sort the Digimons using either, HP, ATK, or Name");
        string? userInput = Console.ReadLine();
        Control.SortByUserChoice(result, userInput ?? "name");
    }


}
