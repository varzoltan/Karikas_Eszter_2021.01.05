using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karikas_Eszter_2021._01._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat (Házi): Készítsünk programot, amely bekér két egész számot, 
            //majd a nagyobb számból vonja ki a kisebbet, valamint a nagyobb számot ossza el a kisebbel!
            Console.Write("kérem adjon megy egy egész számot: ");
            int szam3 = int.Parse(Console.ReadLine());
            Console.Write("kérem adjon megy egy másik egész számot: ");
            int szam4 = int.Parse(Console.ReadLine());
            if (szam3 > szam4)
            {
                Console.WriteLine($"a nagyobb számból a kisebbet, ha kivonom: {szam3 - szam4}, és a nagyobbat osztva a kisebbel: {szam3 / szam4}");
            }
            else 
            {
                Console.WriteLine($"a nagyobb számból a kisebbet, ha kivonom: {szam4 - szam3}, és a nagyobbat osztva a kisebbel: {szam4 / szam3}");
            }
            //2.feladat: Készítsünk programot, amely bekér a felhasználótól két számot. 
            //A program döntse el, hogy az elsőként bekért számnak osztója-e a másodikként bekért szám. 
            //Amennyiben igen, írja ki az osztás eredményét is.
            Console.Write("kérem adjon megy egy egész számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("kérem adjon megy egy másik egész számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1 % szam2 == 0) 
            {
                Console.WriteLine($"szam2 osztója szam1-nek, az eredménye pedig: {szam1 / szam2}");
            }

            //3.feladat: Készítsünk programot, mely eldönti egy háromszög három oldala alapján, 
            //hogy az adott háromszög szerkeszthető-e.
            Console.Write("kérem adjon megy egy egész számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("kérem adjon megy egy másik egész számot: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("kérem adjon megy egy egész számot: ");
            int c = int.Parse(Console.ReadLine());
            if(a-b < c && b-c < a && c-a < b)
            {
                Console.WriteLine($"Szerkeszthető a háromszög");
            }
            else
            {
                Console.WriteLine($"A háromszög nem szerkeszthető");
            }

            //4.feladat: Készítsünk programot, amely bekér egy N számot és kiírja a számokat 1-től N-ig.
            Console.Write("kérem adjon megy egy egész számot: ");
            int N = int.Parse(Console.ReadLine());
            int i  = 1;
            Console.Write($"A számok 1-től N-ig: ");
            while  (i<=N)
            {             
                Console.Write(i+" ") ;
                i++;
            }
            Console.Write($"A számok 1-től N-ig: ");
            for (i = 1; i <= N; i++)
            {
                Console.Write(i + " ");
            }

            //5.1 feladat: Feltölt egy N elemű tömböt egy és száz közé eső véletlen számokkal. 
            //A tömb méretét a felhasználó határozza meg!
            Console.Write("kérem adjon megy egy tömbszámot: ");
            N = int.Parse(Console.ReadLine());
            int[] tomb = new int[N];
            Random szamok  = new Random();
            Console.ReadKey();
        }
    }
}
