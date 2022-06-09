using System;

namespace classWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, count, a, sum;
            a = 0;
            sum = 0;
            count = 1;


 Line1:
            Console.Write("Kindly input a number between 95 and 121: ");
            num = Convert.ToDouble(Console.ReadLine());
            sum += num;

            if (num >= 95 && num <= 121)
            {
                if (count < 5)
                {
                    Console.WriteLine(sum);
                    count++;
                    goto Line1;
                }
                else
                {
                    a = sum / 5;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                goto Line1;
            }
            Console.WriteLine(a);
            if (a >= 100)
            {
                Console.Write("Average is greater than or equal to 100");
            }
            else
            {
                Console.Write("Average is less than or equal to 100");
            }
        }
    }
}
