using System;

namespace ProblemaInfoBac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            problema32023();
            //problema32023var2();
            
           
        }
        static void problema32023()
        {
            Console.WriteLine("Introduceti text:");
            int aux;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                if (checkSameDigits(i) = true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static string checkSameDigits(int N)
        {

            // Find the last digit
            int digit = N % 10;

            while (N != 0)
            {

                // Find the current last digit
                int current_digit = N % 10;

                // Update the value of N
                N = N / 10;

                // If there exists any distinct
                // digit, then return No
                if (current_digit != digit)
                {
                    return "No";
                }
            }

            // Otherwise, return Yes
            return "Yes";
        }
    }
}
//Cerinta: Scrieți un program care citind două valori naturale a și b scrie în fișierul bac.txt toate
//valorile naturale din intervalul[a, b] care au toate cifrele egale, separate prin câte un spațiu.
//Proiectați un algoritm eficient din punctul de vedere al memoriei utilizate și al timpului de executare.
 
