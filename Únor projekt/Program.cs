using System;

namespace Únor_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aktuální čas
            DateTime cas = DateTime.Now;

            //Vytvoření první proměnné
            int cisloMesice = cas.Month;

            //Vytvoří pole o velikosti 12 měsíců
            string[] pole = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Zaří", "Říjen", "Listopad", "Prosinec" };

            //Vypíše minulý, aktuální a budoucí měsíc
            Console.WriteLine($"Teď je: {pole[cisloMesice - 1]}, další měsíc: {pole[cisloMesice]}, předchozí měsíc: {pole[cisloMesice -2]}");
            Console.Write("Zadejte číslo měsíce (1-12): ");

            //Vytvoření další proměnné a konverze
            int mesic = Convert.ToInt32(Console.ReadLine());
            int mesicMinus = mesic - 1;
            int mesicMinusDva = mesic - 2;

            //Vytvoření cyklů
            if (mesic >= 2 && mesic <= 11)
            {
                Console.WriteLine($"Teď je:{pole[mesicMinus]}, další měsíc: {pole[mesic]}, předchozí měsíc: {pole[mesicMinusDva]}");
            }
            else if (mesic == 1)
            {
                Console.WriteLine($"Teď je:{pole[0]}, další měsíc: {pole[1]}, předchozí měsíc: {pole[11]}");
            }
            else if (mesic == 12)
            {
                Console.WriteLine($"Teď je:{pole[11]}, další měsíc: {pole[0]}, předchozí měsíc: {pole[10]}");
            }

            //Zeptá se jestli chceme vypsat měsíce, vybereme ano/ne (y/n)
            Console.WriteLine("Chcete vypsat všechny měsíce, y/n?");
            string anoNe = Console.ReadLine();
            if (anoNe == "y")
            {
                foreach (string ano in pole)
                {
                    Console.WriteLine(ano);
                }
            }
            else if (anoNe == "n")
            {
                Console.WriteLine("Tak kys");
            }
            //Kdyby se konzole vypla před vypsáním měsíců, přidáme na konec:
            //Console.ReadKey();
        }
    }
}
