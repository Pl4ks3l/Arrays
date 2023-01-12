using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qrrqyu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Axel De Vuyst
            // 12/01/2023
            // Project Array

            // Velden
            String[] _namen = new string[5];
            Random _rdm = new Random();
            int _keuze = 0;
            bool _herhalen = true;


            // Programma

            //Herhaal
            do
            {
                //foutmelding bij geen getal
                try
                {
                    //Keuze Menu
                    Console.WriteLine($"1) 5 Namen invoeren");
                    Console.WriteLine($"2) Toon Namen");
                    Console.WriteLine($"3) Random naam kiezen");
                    Console.WriteLine($"4) Programma afsluiten");

                    //Ingaven van gebruiker
                    _keuze = int.Parse(Console.ReadLine());
                    Console.Clear();
                    
                }
                catch
                {
                    Console.WriteLine($"Dit is geen getal of u heeft een keuze ingegeven dat niet kan");
                    Console.WriteLine($"Druk op enter om verder te gaan.");
                    Console.ReadKey();
                    Console.Clear();
                }

            // Vraag de namen aan de gebruiker
                if(_keuze == 1)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Geef naam {i + 1}:");
                        _namen[i] = Console.ReadLine();
                        Console.WriteLine();
                        _keuze = 0;
                    }

                    //Scherm leegmaken
                    Console.Clear();
                }

                //als de eerste aray niet leeg is start de programma binne de haakjes
                if (_namen[0] != null)
                {
                    //als hij voor keuze 2 heeft gekozen start de programma binne de haakjes
                    if (_keuze == 2)
                    {
                        foreach (string s in _namen)
                        {
                            Console.WriteLine(s);

                        }
                        Console.WriteLine("\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                        Console.Clear();
                        _keuze = 0;
                    }

                    //als hij voor keuze 3 heeft gekozen start de programma binne de haakjes
                    else if (_keuze == 3)
                    {
                        //Scherm leegmaken
                        Console.Clear();

                        Console.WriteLine(_namen[_rdm.Next(_namen.Count())]);

                        Console.WriteLine("\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                        Console.Clear();
                        _keuze = 0;
                    }
                }

                //als de 1ste array leeg is start de programma binne de haakjes
                else if (_namen[0] == null)
                {
                    Console.WriteLine($"U moet eerst namen toevogen aan de array");
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                    Console.Clear();
                }

                //als hij keuze 4 heeft sluit het programma af
                if(_keuze == 4)
                {
                    _herhalen = false;
                }
            } while (_herhalen == true);

        }
    }
}
