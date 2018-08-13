using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            
              //Task One:
                Console.Write("Guess what my fav animal is!");
                string guess = Console.ReadLine();

                Task1(guess);
            

            //Task Two:
                Console.Write("Enter the name of the fruit you want to know the price for!");
                string fruit = Console.ReadLine();
                Task2(fruit);


            //Task Three:

                Console.Write("Enter ONE number!");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter another number!");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Enter an operator you would like to use for these 2 numbers, ie. +, -, /, *");
                string userOp = Console.ReadLine();

            Task3(num1, num2, userOp);
            
        }

        public static void Task1(string guess)
        {
            //Switch statement checking for same animal
            switch (guess)
            {
                case "rabbit":
                    Console.Write("Correct!");
                    break;
                case "dogs":
                    Console.Write("Correct!");
                    break;
                case "chicken":
                    Console.Write("Correct!");
                    break;
                case "parrots":
                    Console.Write("Correct!");
                    break;
                default:
                    Console.Write("Unexpected animal/thing entered.");
                    break;
            }
        }


        public static void Task2(string fruit)
        {
            //Switch statement for checking fruit enetered
            switch (fruit)
            {
                case "Apple":
                    Console.Write("$1.25/kg");
                    break;
                case "Banana":
                    Console.Write("$3.15/kg");
                    break;
                case "Kiwifruit":
                    Console.Write("$4.65");
                    break;
                case "Orange":
                    Console.Write("$2.75");
                    break;
                default:
                    Console.Write("Sorry the incorrect fruit was entered. Try Again!");
                    break;
            }
        }

        public static void Task3(int num1, int num2, string userOp)
        {
            //Switch statement for calculator
            switch (userOp)
            {
                case "+":
                    Console.Write(num1 + num2);
                    break;
            case "-":
                    Console.Write(num1 - num2);
                    break;
                case "/":
                    Console.Write(num1 / num2);
                    break;
                case "*":
                    Console.Write(num1 * num2);
                    break;
                default:
                    Console.Write("Something went wrong, try agian!");
                    break;
            }
           
            
        }
    }
}
