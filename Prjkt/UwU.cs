using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prjkt
{
    internal class UwU
    {
        

        public void JakG()
        {
            G game = new G();

            Thread.Sleep(1000);
            Console.WriteLine("Czy chcesz spróbować ocalić kraj?");
            string wyb = Console.ReadLine();
            
            if (wyb == "y")
            {
                Thread.Sleep(1000);
                Console.WriteLine("W co chcesz zagrać?");
                Thread.Sleep(1000);
                Console.WriteLine("Papier, kamień, nożyce - 1");
                Thread.Sleep(1000);
                Console.WriteLine("Kółko i krzyżyk - 2");
                int odp = int.Parse(Console.ReadLine());
                if (odp == 1)
                {
                    game.Pkn();
                    
                }
                if (odp == 2)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Jakbyś miał jakiś wybór  ...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Grasz w papier kamień noźyce i tyle.");
                    Thread.Sleep(1000);
                    game.Pkn();
                }
                
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine("Brak słów...");
            }
            
            

        }



    }
}
