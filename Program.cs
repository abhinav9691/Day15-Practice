using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Day15_PracticeProblem
{
    public class Program
    {
        static bool evendigits(int number)
        {
            int rem = 0;
            while (number > 0)
            {
                rem = number % 10;
                if (rem % 2 != 0)
                {
                    return false;
                }
                number = number / 10;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number ");
            int number = int.Parse(Console.ReadLine());
            int num1 = number, num2 = number;
            while (!evendigits(num1))
            {
                num1 -= 1;
            }
            while (!evendigits(num2))
            {
                num2 += 1;
            }
            int diff1 = number - num1;
            int diff2 = number - num2;
            int lowestnum = num1;
            if (diff1 > diff2)
            {
                lowestnum = num2;
            }
            Console.WriteLine(lowestnum);
            NearestNumber.FindType();
            NearestNumber.ReflectionTest();
        }
    }
}