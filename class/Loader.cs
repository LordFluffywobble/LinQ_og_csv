using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq;
using Microsoft.VisualBasic;

namespace MVC_og_LinQ;

internal class Loader
{
        
          
        internal List<Digimon> LoadMethod()
    {
        List<Digimon> digimons = new();
        var lines = File.ReadAllLines(@"C:\Users\bonym\Documents\Pkurs\MVC og LinQ\archive\DigiDB_digimonlist.csv").Skip(1);

        foreach (var line in lines)
        {
            var col = line.Split(','); // Split line into columns
            Digimon digi = new()
            {
                Number = int.Parse(col[0]),
                Name = col[1],
                Stage = col[2],
                Type = col[3],
                Attribute = col[4],
                Memory = int.Parse(col[5]),
                EquipSlots = int.Parse(col[6]),
                Lv50HP = int.Parse(col[7]),
                Lv50SP = int.Parse(col[8]),
                Lv50ATK = int.Parse(col[9]),
                Lv50DEF = int.Parse(col[10]),
                Lv50INT = int.Parse(col[11]),
                Lv50SPD = int.Parse(col[12]),
            };
            digimons.Add(digi);
        }
        return digimons;
            //Check if it was parsed right
            // Console.WriteLine("Digomon data: \n");
            // foreach (var d in digimons)
            // {
            //     Console.WriteLine($"{d.Number} {d.Name} {d.Stage} {d. Type} {d. Attribute} {d.Memory} {d.EquipSlots} {d.Lv50HP} {d.Lv50SP} {d.Lv50ATK} {d.Lv50DEF} {d.Lv50INT
            //     } {d.Lv50SPD}");
            // }
        
    }        


    //Printing out all Digimons with an HP over 1000
    // internal void OverThousand()
    // {
        
    //         HighHP = digimons.Where(d => d.Lv50HP > 1000).ToList();
            
    //         foreach (var d in HighHP)
    //         {
    //         Console.WriteLine($" {d.Name}: {d.Stage} ");
    //         }
    // }

}