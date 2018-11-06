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

            //Orario o2 = new Orario(12, 4, 59);

            //var mezzaNotte = new Orario
            //{
            //    Ora = 0,
            //    Minuti = 0,
            //    Secondi = 0
            //};

            //var mezzoGiorno = new Orario
            //{
            //    Ora = 12,
            //    Minuti = 0,
            //    Secondi = 0
            //};

            //Orario oraDiPranzo = mezzoGiorno;

            //var orari = new Orario[24];
            //for (int ora = 0; ora < 24; ora++)
            //{
            //    orari[ora].Ora = ora;
            //    orari[ora].Minuti = 0;
            //    orari[ora].Secondi = 0;
            //}

            Data inizioSecolo = new Data(1, 1, 1900);

            Data fineSecolo = new Data(31, 12, 1999);

            int giorni = fineSecolo.Differenza(inizioSecolo);

            Console.WriteLine(giorni);
       
            Console.WriteLine("Fine!");
            Console.ReadLine();
        }
    }
}
