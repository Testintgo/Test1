using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    static void Main(string[] args)
    {
        Person gosho = new Person("Gosho", 24);
        Person pesho = new Person("Pesho", 35, "pesho@abv.bg");
        //Person wrongEmail = new Person("Gosho", 25, "pesho");
        //Person wrongAge = new Person("Iliq", 101);

        Console.WriteLine(gosho);
        Console.WriteLine(pesho);
        //Console.WriteLine(wrongEmail);
        //Console.WriteLine(wrongAge);        
    }

}


