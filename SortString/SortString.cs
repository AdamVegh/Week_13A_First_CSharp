using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is our nice sentence:");
            string niceString = "Microsoft .NET Framework 2.0 Application Development Foundation";
            Console.WriteLine(niceString);
			Console.WriteLine();

			Console.WriteLine("Now we will split this sentence on its spaces:");
            string[] splittedString = niceString.Split(' ');
            foreach (string item in splittedString)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

			Console.WriteLine("Let's sort this words in alphabet:");
            Array.Sort(splittedString);
            foreach (string item in splittedString)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

			Console.WriteLine("And the last thing: Let's join these words with spaces:");
            string newString = string.Join(" ", splittedString);
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
