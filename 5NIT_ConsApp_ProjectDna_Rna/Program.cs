using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// 
/// Naam: Dhr. Gillade Tom
/// Datum: 26/10/2020
/// Project: DNA wordt RNA
///

namespace _5NIT_ConsApp_ProjectDna_Rna
{
    class Program
    {
        static void Main(string[] args)
        {
            String RNA = "";

            for (int teller = 0; teller < 12; teller++)
            {
                Console.Write("Gelieve een letter in te geven:    ");
                Char letter = Convert.ToChar(Console.ReadLine().ToUpper()) ;

                switch (letter)
                {
                    case 'G':
                        RNA += 'C';
                        break;
                    case 'C':
                        RNA += 'G';
                        break;
                    case 'T':
                        RNA += 'A';
                        break;
                    case 'A':
                        RNA += 'U';
                        break;
                    default:
                        teller -= 1;
                        break;
                }
            }

            Console.WriteLine($"Jouw DNA levert volgende RNA-code op: {RNA}");

            Console.ReadKey();
        }
    }
}
