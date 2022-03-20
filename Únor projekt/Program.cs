using System;

namespace Únor_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime cas = DateTime.Now;
            int cisloMesice = cas.Month;
            string[] pole = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Zaří", "Říjen", "Listopad", "Prosinec" };
            Console.WriteLine($"Teď je:{pole[cisloMesice - 1]}, další měsíc: {pole[cisloMesice]}, předchozí měsíc: {pole[cisloMesice -2]}");
            Console.Write("Zadejte číslo měsíce (1-12): ");

            int mesic = Convert.ToInt32(Console.ReadLine());
            int mesicPlus = mesic + 1;
            int mesicMinus = mesic - 1;
            int mesicMinusDva = mesic - 2;


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
            Console.WriteLine("Chcete vypsat všechny měsíce, Y/N?");
            string anoNe = Console.ReadLine();
            if (anoNe == "Y")
            {
                foreach (string ano in pole)
                {
                    Console.WriteLine(ano);
                }
            }
            else if (anoNe == "N")
            {
                Console.WriteLine("Tak kys");
            }







        }
    }
}
