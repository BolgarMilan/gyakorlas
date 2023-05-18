using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace slagerlista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zenek = new List<string>();
            Dictionary<string, int> darab = new Dictionary<string, int>();
            string[] menupontok = { "Új adat bevitele", "10 hely kiírása", "Kilép" };
            Console.Clear();
            while (true)
            {
                for (int i = 0; i < menupontok.Length; i++)
                {
                    Console.WriteLine((i + 1) + " " + menupontok[i]);
                }
                char valasz = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (valasz)
                {
                    case '1':
                        string eloado = "asd";
                        string SzamCim = "asd";
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"{i + 1} Adjon meg egy előadót");
                            eloado = Console.ReadLine();
                            Console.WriteLine($"{i + 1} Adjon meg egy szám címet");
                            SzamCim = Console.ReadLine();
                            zenek.Add(eloado + " " + SzamCim);

                            if (darab.ContainsKey(eloado + " " + SzamCim))
                            {
                                darab[eloado + " " + SzamCim]++;
                            }
                            else
                            {
                                darab[eloado + " " + SzamCim] = 1;
                            }
                        }
                        foreach (var item in darab)
                        {
                            Console.WriteLine(item.Key + " " + item.Value + "db");
                        }
                        break;
                    case '2':
                        var rendezett = darab.OrderByDescending(zenek => zenek.Value);
                        foreach (var item in rendezett)
                        {
                            Console.WriteLine(item.Value+ " " +item.Key);
                        }
                        break;
                    case '3':
                        Environment.Exit(999999999);
                        break;
                }
            }
        }
    }
}