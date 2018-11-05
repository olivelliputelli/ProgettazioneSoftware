using System;
using ChatClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Orario o1 = new Orario
            //{
            //    Ora = 12,
            //    Minuti = 0,
            //    Secondi = 0
            //};

            //Data d1 = new Data(12, 10, 2010);

            //Messaggio m1 = new Messaggio
            //{
            //    DataMessaggio = d1,
            //    OrarioMessaggio = o1,
            //    TestoMessaggio = "Ciao Mondo",
            //    IsRicevuto = true
            //};             
            var mezzaNotte = new Orario
            {
                Ora = 0,
                Minuti = 0,
                Secondi = 0
            };

            var mezzoGiorno = new Orario
            {
                Ora = 12,
                Minuti = 0,
                Secondi = 0
            };

            Orario oraDiPranzo = mezzoGiorno;

            var orario = new Orario[24];
            for (int ora = 0; ora < 24; ora++)
            {
                orario[ora].Ora = ora;
                orario[ora].Minuti = 0;
                orario[ora].Secondi = 0;
            }

            Console.WriteLine("Fine!");
            Console.ReadLine();
        }
    }
}
