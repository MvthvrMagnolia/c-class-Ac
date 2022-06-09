using System;

namespace calcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, answer;
            string result, reply;

            Console.Write("Kindly enter a number: ");
           num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kindly enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
Line1:
            Console.WriteLine("What would you like to do with these numbers?");
            result = Console.ReadLine();

            if (!string.IsNullOrEmpty(result))
            {
                if (result.ToLower() == "sum")
                {
                    answer = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + answer);
                }
                else if (result.ToLower() == "subtract")
                {
                    answer = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + answer);
                }
                else if (result.ToLower() == "divide")
                {
                    answer = num1 / num2;
                    answer = Math.Round(answer, 2);
                    Console.WriteLine(num1 + " / " + num2 + " = " + answer);
                }
                else if (result.ToLower() == "multiply")
                {
                    answer = num1 * num2;
                    answer = Math.Round(answer, 2);
                    Console.WriteLine(num1 + " * " + num2 + " = " + answer);
                }
                else if (result.ToLower() == "nothing")
                {
                    goto Line2;
                }
                else
                {
                    Console.WriteLine("I do not understand what you want");
                }
                Console.Write("Do you want to perform another operation? ");
                reply = Console.ReadLine();

                if (reply.ToLower() == "yes")
                {
                    goto Line1;
                }
                else
                {
                    goto Line2;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid operation: sum, multiply, divide, subtract or nothing");
                goto Line1;
            }
Line2:
            Console.WriteLine("Thank you for your time.");

        }
    }
}
