using System;

namespace Uppgift_2._11
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång har Elin hoppat?");
            String hoppade = Console.ReadLine();
            int Elin = Convert.ToInt32(hoppade);
            Console.WriteLine("Hur lång hoppade du Alma?");
            string HoppadeAlma = Console.ReadLine();
            int Alma = Convert.ToInt32(HoppadeAlma);
            Console.WriteLine("Elin hoppade " + (Elin - Alma) + " meter längre");
        }

    }
}
