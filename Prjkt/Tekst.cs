using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prjkt
{
    internal class Tekst
    {
        public void Text()
        {
            Random genr = new Random();
            
            int liczba = genr.Next(1, 7);
            int liczba2 = genr.Next(1, 3);
            if (liczba2 == 2)
            {
                string m = "Piwniczak: ";
                if (liczba == 1)
                {
                    Console.WriteLine($"{m} Zagarnę ten kraj tylko dla siebie!");
                }
                if (liczba == 2)
                {
                    Console.WriteLine($"{m} Mój dziadek był miłym panem malujący pejzaże!");
                }
                if (liczba == 3)
                {
                    Console.WriteLine($"{m} Doprowadzę ten kraj do dominacji światowej!");
                }
                if (liczba == 4)
                {
                    Console.WriteLine($"{m} Pozbędę się swojego sasinowego długu gdy zostanę przyfudcom!");
                }
                if (liczba == 5)
                {
                    Thread.Sleep(1500);
                    Console.WriteLine("...");
                    Thread.Sleep(2000);
                    Console.WriteLine($"{m} Muszę coś zjeść...");
                }
                else
                {

                }
            }
        }
        public void Stop()
        {
            Thread.Sleep(2000);
            Console.WriteLine(new string('-', 100));
            Thread.Sleep(2000);
            Console.WriteLine("Stop.");
            Thread.Sleep(2000);
            Console.WriteLine("Masz szansę na uratowanie swojego komunistycznego kraju!");
            Thread.Sleep(1000);
            Console.WriteLine("Jednak musisz stawić czoła z piwniczakiem, który stworzył sekretną grupę próbującą przejąć kraj!");
        }
    }

}

