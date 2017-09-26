using System.Collections.Generic;
using System;﻿
namespace DataTypesAndVariables.Excercise1
{
    public class Operators
    {
        public static void Main(string[] args)
        {
            /*
            += -= *= /= %= are different types of mathematical operators.So, addition(+), subtraction(-), multiplication(*), division(/) and the Modulo operator(%).

            Now, the "=" also plays a part in these operations. For example, consider the addition operator(+=).The '+' will actually perform the addtion while the '=' will assign that value to the variable.

            So, if we declare that X = 5 then 'X += 2' will set the value of X as 7.The '+' adds 2 to 5 and the '=' assigns the value 7 to the variable X.


            */

            //Write a program that declares a variable with an initial value of 9.
            int n = 9;
            //Now use the addition operator to add the variable with itself
            n += n;
            Console.WriteLine($"n + n:{n}");
            //use that same variable again and subtract 2 from itself using the subtraction operator
            n -= 2;
            Console.WriteLine($"n - 2 :{n}");

            //use the multiplication operator to multiply the integer by 8
            n *= 8;
            Console.WriteLine($"n * 8 :{n}");

            //use the division operator to divide the integer by 3
            n /= 3;
            Console.WriteLine($"n / 3 :{n}");

            //use the modulus operator to mod the integer by 10
            Console.WriteLine($"n %10 :{n}");
            Console.WriteLine("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}
