using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumberGenerator
{
    class Program
    {
        
        static void Main()
        {
            Random rng = new Random();
            for (int i= 0; i < 10; i++)
                {
                    Console.WriteLine("Your random number is:  ");
                    Console.WriteLine(rng.Next(1, 101));
                    Console.ReadLine();
                
                }

           
        }


    }

   

}
