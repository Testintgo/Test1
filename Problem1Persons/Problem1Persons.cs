using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Problem1Persons
{
    static void Main(string[] args)
    {
        Person John = new Person("ef", 12, "abd@");
        Console.WriteLine(John.ToString());
        Person Jack = new Person("J", 45);
        Console.WriteLine(Jack.ToString());
    }
}

