using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace PluralSite.CSharpEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food("banana");
            Food chocolate = new Food("chocolate");

            Console.WriteLine(banana.Equals(chocolate));
        }
    }
}
