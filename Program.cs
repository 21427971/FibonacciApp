using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FibonacciApp
{
    class Program
    { //Msimango KSI
        static void Main(string[] args)
        { // A C# program to generate fibonacci series.
            int v=0, Count, F1 = 0, F2 = 1, F3 = 0;
            Console.WriteLine("Enter your FullName");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your fibonacci limit:");
            Count = int.Parse(Console.ReadLine());
            Console.WriteLine(F1);
            Console.WriteLine(F2);
          for(v=0;v<=Count;v++)//while(v<=Count)// if using a while loop 
            { 
           // v++; only Add this count if you are using a whileloop to avoid infinite loop
                F3 = F1 + F2;//looking for the next value
                Console.WriteLine(F3);
               // Console.WriteLine($"{F3}");string interpolation
               F1 = F2; F2 = F3;
            }
            Console.WriteLine("**Good to go**");
            //Console.ReadKey();
        }
    }
}
