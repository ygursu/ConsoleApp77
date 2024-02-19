using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilensayipozitifnegatif
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Int32.Parse(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else
            {
                Console.WriteLine("Sayı Negatif");
            }


            Console.ReadLine();
        }
    }
}