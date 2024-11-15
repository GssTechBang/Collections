using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<101; i++)
            {
                if(i % 3 == 0 && i%5 == 0)
                {
                    Console.Write("fizzbuzz" + ",");
                }
                else if(i % 5 == 0)
                {
                    Console.Write("buzz" + ",");
                }
                else if(i % 3 == 0)
                {
                    Console.Write("fizz" + ",");
                }
                else
                {
                    Console.Write(i + ",");
                }
               
            }

        }
    }
}
