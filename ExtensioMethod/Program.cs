using System;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 05, 14, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}