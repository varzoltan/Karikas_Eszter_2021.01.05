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
            //Házi: Készítsünk programot, amely bekér két egész számot, 
            //majd a nagyobb számból vonja ki a kisebbet, valamint a nagyobb számot ossza el a kisebbel!

            //2.feladat: Készítsünk programot, amely bekér a felhasználótól két számot. 
            //A program döntse el, hogy az elsőként bekért számnak osztója-e a másodikként bekért szám. 
            //Amennyiben igen, írja ki az osztás eredményét is.
            Console.Write("kérem adjon megy egy egész számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("kérem adjon megy egy másik egész számot: ");
            int szam2 = int.Parse(Console.ReadLine());
        }
    }
}
