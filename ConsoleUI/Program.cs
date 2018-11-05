using System;
using ChatClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Orario o1 = new Orario();

            o1.Ora = 12;
            o1.Minuti = 0;
            o1.Secondi = 0;


            Data data1 = new Data(12, 10, 2010);
            Data data2 = new Data(13, 10, 2010);

            int differenza = data1.Differenza(data2);

            Console.WriteLine(differenza);
            Console.WriteLine("Fine!");
            Console.ReadLine();
        }
    }
}
