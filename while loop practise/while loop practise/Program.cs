using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop_practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1:
            int n = 3;

            for (n = 3; n < 8; n++)
            {
                Console.WriteLine($"{n}{10 * n}\t{n*100}\t{ n * 1000}");

            }

            while (n< 8)
            {
                Console.WriteLine($"{n}{10 * n} + {100 * n} + {1000 * n}");
                n++;
            }

            do
            {
                Console.WriteLine($"{n}\t{n * 10}\t\t{n * 100}\t\t{n * 1000}");
                n++;
            } while (n <= 7);

            //Task 2:

            Console.WriteLine("Please enter a number to multiply with the 12 times tables!");
            int i = int.Parse(Console.ReadLine());
            int start = 1;

            //FOR LOOP
            for (start = 1; start<13; start++)
            {
                Console.WriteLine($"{start}{i}{start*i}");
            }

            //WHILE LOOP
            while (start < 13)
            {
                Console.WriteLine($"{i}{start}{start*i}");
                start++;
            }


            //DO/WHILE LOOP
            do
            {
                Console.WriteLine($"{i}{start}{start * i}");
                start++;
            } while (start<13);
        }

     
    }
}
