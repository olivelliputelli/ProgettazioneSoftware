using System;
using ChatClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data1 = new Data(12, 10, 2010);
            Data data2 = new Data(13, 10, 2010);

            int differenza = data1.Differenza(data2);

            Console.WriteLine(differenza);
            Console.WriteLine("Fine!");
            Console.ReadLine();
        }
    }
}
