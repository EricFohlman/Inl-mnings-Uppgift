using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int compnum = rnd.Next(1, 100);
            bool status = true;
            int usercount = 0;

            Console.WriteLine("gissa ett nummer mellan 1 och 100");
            
            while (status)
            {
                usercount ++ ;

                Console.WriteLine("Skriv ett tal: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int usernum);
                
                if (usernum == compnum)
                {
                    Console.WriteLine("Du gissade rätt!");
                    Console.WriteLine("Antal gissningar: " + usercount);
                    status = false;
                }

                else
                {
                     if (usernum < compnum)
                     {
                        Console.WriteLine("Talet är större!");
                     }
                     else if (usernum > compnum)
                     {
                        Console.WriteLine("Talet är mindre!");
                     }

                }
                
                
            }

        }
    }
}

