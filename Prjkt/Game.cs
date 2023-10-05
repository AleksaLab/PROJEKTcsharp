using System;
using System.Collections.Generic;
using System.Threading;

namespace Prjkt
{
    public class Game
    {
        private List<Dictionary<string, object>> actions;
        private int tury;
        private Kraj kraj;

        public Game()
        {
            actions = new List<Dictionary<string, object>>()
        {
            new Dictionary<string, object>
            {
                {"pytanie", "Ograniczyć budżet wojska?"},
                {"skutki", new Dictionary<string, int> {{"wojsko", -40}, {"ekonomia", 20}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Rozpocząć śledztwo dotyczące żołnierzy szmuglujących broń?"},
                {"skutki", new Dictionary<string, int> {{"ludnosc", 20}, {"wojsko", -20}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Szukać złóż oleju?"},
                {"skutki", new Dictionary<string, int> {{"ekonomia", 50}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Przywrócić obowiązkowy pobór do wojska?"},
                {"skutki", new Dictionary<string, int> {{"ludnosc", -40}, {"wojsko", 40}, {"satysfakcja", -20}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Zezwolić na eksperymenty na zbożu?"},
                {"skutki", new Dictionary<string, int> {{"ekologia", 20}, {"ekonomia", -20}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Zwiększyć budżet wojska?"},
                {"skutki", new Dictionary<string, int> {{"wojsko", 15}, {"ekonomia", -20}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Ukarać ruskich trolli?"},
                {"skutki", new Dictionary<string, int> {{"ludnosc", -15}, {"ekonomia", 15}, {"satysfakcja", 40}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Zwiększyć wyposażenie wojska?"},
                {"skutki", new Dictionary<string, int> {{"ekonomia", -15}, {"wojsko", 20}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Zafundować X-menów?"},
                {"skutki", new Dictionary<string, int> {{"wojsko", 90}, {"ekonomia", -20}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Wydać 70 milionów polskich złociszy na wybory które się nie odbędą?"},
                {"skutki", new Dictionary<string, int> {{"ekonomia", -2137}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Zwiększenie produkcji kremówek?"},
                {"skutki", new Dictionary<string, int> {{"satysfakcja", 100}, {"ekonomia", -5}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Zwiększenie produkcji wódki 42.0%?"},
                {"skutki", new Dictionary<string, int> {{"satysfakcja", 30}, {"ekonomia", -10}, {"ludnosc", -10}}},
            },
            new Dictionary<string, object>
            {
                {"pytanie", "Zezwolić na małżeństwa homoseksualne?"},
                {"skutki", new Dictionary<string, int> {{"satysfakcja", -10000000}, {"ekonomia", -10000000}, {"ludnosc", -10000000}, {"wojsko", -10000000}, {"ekologia", -10000000}}},
            }
        };
            tury = 20;
            kraj = new Kraj("Państwo");
        }

        public void Play()
        {
            while (tury > 0)
            {

                Console.WriteLine(kraj);
                Console.WriteLine(new string('-', 100));
                var action = actions[new Random().Next(0, actions.Count)];
                Thread.Sleep(1000);
                Console.WriteLine(action["pytanie"]);
                Thread.Sleep(1000);
                var choice = Console.ReadLine();
                Thread.Sleep(1000);
                Console.WriteLine(new string('-', 100));

                if (choice == "y")
                {
                    var skutki = (Dictionary<string, int>)action["skutki"];
                    foreach (var skutek in skutki)
                    {
                        switch (skutek.Key)
                        {
                            case "wojsko":
                                kraj.wojsko += skutek.Value;
                                break;
                            case "ekonomia":
                                kraj.ekonomia += skutek.Value;
                                break;
                            case "ludnosc":
                                kraj.ludnosc += skutek.Value;
                                break;
                            case "ekologia":
                                kraj.ekologia += skutek.Value;
                                break;
                            case "satysfakcja":
                                kraj.satysfakcja += skutek.Value;
                                break;
                        }
                    }
                    kraj.Checker();


                    if (kraj.wojsko <= 0 || kraj.ludnosc <= 0 || kraj.ekologia <= 0 || kraj.satysfakcja <= 0)
                    {
                        break;
                    }
                }
                else if (choice != "n")
                {
                    Console.WriteLine("DEBILU NAUCZ SIĘ MYŚLEĆ!!!!!!!!!!!!!!!!!!!!!!!");
                }

                tury--;
            }
            UwU kl = new UwU();
            Tekst ms = new Tekst();
            Console.WriteLine("Koniec ruchów elo!");
            Console.WriteLine(kraj);
            ms.Stop();
            kl.JakG();
        }
    }
}