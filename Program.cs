using System;
using static test_neolink_bpo.alien_numeral;

namespace test_neolink_bpo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input: s = ");
            string s = Console.ReadLine();
            convert_alien_numeral(s);
        }
    }
}
