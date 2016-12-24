using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable stuff
            int x;
            int y;

            x = 7;
            y = x + 3;
            
            Console.WriteLine(y);
            Console.ReadLine();

            //string work
            Console.WriteLine("What is your Name?");
            Console.Write("Type ypur first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Type ypur last name: ");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + ".");
        }
    }
}
