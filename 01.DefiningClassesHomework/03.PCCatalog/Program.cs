using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        List<Computer> catalog = new List<Computer>();
        List<Component> compDell = new List<Component>();
        compDell.Add(new Component("CPU", 236));
        compDell.Add(new Component("Motheboard", 352));
        compDell.Add(new Component("Graphics card", 337));
        Computer dell = new Computer("Dell", compDell);
        
        List<Component> compToshiba = new List<Component>();
        compToshiba.Add(new Component("HDD", 150.82m));
        compToshiba.Add(new Component("CPU", 360.75m));
        compToshiba.Add(new Component("RAM", 102.90m));
        Computer toshiba = new Computer("Toshiba", compToshiba);

        List<Component> compHp = new List<Component>();
        compHp.Add(new Component("CPU", 534));
        compHp.Add(new Component("RAM", 323.65m, "16GB"));
        Computer hp = new Computer("HP", compHp);
        
        catalog.Add(dell);
        catalog.Add(toshiba);
        catalog.Add(hp);

        var sortCatalog = catalog.OrderByDescending(computer => computer.Price);

        foreach (var computer in sortCatalog)
        {
            Console.WriteLine(computer);
        }
    }
}

