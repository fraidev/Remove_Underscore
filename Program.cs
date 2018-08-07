using System;

namespace Remove_Underscore
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine();
            var result = x.Replace("_", " ");
            Console.WriteLine(result);
        }
    }
}
