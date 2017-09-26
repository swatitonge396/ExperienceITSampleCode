using System.Collections.Generic;
using System;

namespace DataTypesAndVariables.Excercise1
{
    public class Loops
    {
        public static void Main(string[] args)
        {
            //do while loop

            //Write a program that uses a do while statement. Inside the loop, a kid is asking "are we there yet"
            //Then ask the user for input. The loop ends when we have arrived and then print to the console that "We're here!"
            string response;
            do
            {
                Console.WriteLine("are we there yet?");
                Console.WriteLine("Enter your asnwer :");
                response = Console.ReadLine();

            } while (response.ToLower() != "arrived");
            Console.WriteLine("we are here!!!");
            //while loops

            //Write a program using a while loop that counts by 5's up to 100 starting at 5
            //Ex 5 10 15 20 25 30 etc
            int i = 5;
            while (i <= 100)
            {
                Console.Write($" {i} ");
                i += 5;
            }
            Console.WriteLine();
            //for loops

            //Write a program that uses a for loop to count down from 30 to 0, by 3's
            //Ex 30 27 24 21 18 etc
            for (i = 30; i >=0 ; i -= 3)
            {
                Console.Write($" {i} ");
            }
            //post and pre increment
            Console.WriteLine();
            //write a program that uses a for loop with a pre incrementing counter and stops at <= 10 and increases by 1 each time
            //what is the final number printed?
            for (i = 0; i<=10; ++i)
            {
                Console.Write($" {i} ");
            }
            //write a program that uses a for loop with a post incrementing counter and stops at <= 10 and increases by 1 each time
            //what is the final number printed?
            Console.WriteLine();
            for (i = 0; i <= 10; i++)
            {
                Console.Write($" {i} ");
            }

            //foreach
            Console.WriteLine();
            List<int> numbers = new List<int> { 1, 3, 2, 4, 9, 20, 83, 88, 10, -2, -3 };
            //use a foreach loop to go over this list of numbers and only print the even numbers, not the odd
            foreach(int number in numbers)
            {   if(number%2 ==0)
                Console.Write($" {number} ");
            }
            Console.WriteLine("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}
