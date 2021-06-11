using System;

namespace CS022PoleLicheCislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CS022PoleLicheCislo - Aleš Adamec");
            Console.WriteLine("Zadejte pole celých čísel, čísla oddělujte čárkou bez mezery:");
            Console.WriteLine(
                "Pole obsahuje liché číslo?: {0}", 
                Liche(IntPole(Console.ReadLine().Split(','))) ? "Ano" : "Ne");
            Console.ReadKey();
        }

        private static int[] IntPole(string[] pole)
        {
            var vystup = new int[pole.Length];

            for (int i = 0; i < pole.Length; i++)
                vystup[i] = int.Parse(pole[i]);

            return vystup;
        }
        static bool Liche(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
                if (Liche(pole[i])) 
                    return true;

            return false;
        }
        static bool Liche(int cislo)
        {
            return (cislo % 2) == 1;
        }
    }
}
