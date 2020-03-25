using System;

namespace Verdoppelungsshit
{
    class Program
    {
        static void Main(string[] args)
        {
            Double z = Convert.ToInt32(Console.ReadLine());

            while(true)
            {
                double b;

                z = 2 * z;
                b = z / 2;

                Console.WriteLine(z);

                if (b >= 20)
                {
                    Console.WriteLine("hui");
                }

                Console.ReadKey();
            }


           
              


               
        }
    }
}
