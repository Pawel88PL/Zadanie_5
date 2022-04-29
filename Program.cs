using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie nr 5
            // Program bada czy podana liczba jest liczbą pierwszą.

            // Zadeklarowanie zmiennych
            bool CzyPierwsza = true;
            string koniec;

            // Działanie programu w pętli.
            do
            {
                Console.WriteLine("Program bada czy podana liczba jest liczbą pierwszą.");
                Console.WriteLine();
                Console.Write("Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (a <= 1)
                    {
                        Console.WriteLine("To nie jest liczba pierwsza ani złożona.");
                    }
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(a); i++)
                        {
                            if (a % i == 0)
                            {
                                CzyPierwsza = false;
                                Console.WriteLine("Liczba {0} jest liczbą złożoną podzielną przez samą siebie, 1 i np. przez {1}", a, i);
                                break;
                            }
                        }
                        if (CzyPierwsza)
                        {
                            Console.WriteLine("Liczba {0} jest liczbą pierwszą", a);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawna wartość dla podanej liczby.");
                }
                Console.WriteLine();
                Console.WriteLine("Czy chcesz zakończyć działanie programu? (tak/nie)");
                koniec = Console.ReadLine();
                Console.WriteLine();
            }
            while (koniec == "nie");
        }
    }
}
