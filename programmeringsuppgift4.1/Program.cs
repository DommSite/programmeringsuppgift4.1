using System;

namespace inlämningsuppgift4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int förstatal = 10; förstatal <= 30; förstatal = förstatal + 1)
            {
                Console.WriteLine(förstatal);
            }
            Console.ReadKey();
            for (int andratal = 200; andratal >= 180; andratal = andratal - 1)
            {
                Console.WriteLine(andratal);
            }
            Console.ReadKey();
            for (int tredjetal = 1000; tredjetal <= 1400; tredjetal = tredjetal + 50)
            {
                Console.WriteLine(tredjetal);
            }
            Console.ReadKey();
        }

    }
}