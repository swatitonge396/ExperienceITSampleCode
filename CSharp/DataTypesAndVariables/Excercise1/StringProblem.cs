using System.Collections.Generic;
using System;

namespace DataTypesAndVariables.Excercise1
{
    public class StringProblem
    {
        public static void Main(string[] args)
        {

            //To use this class Click the solution Explorer tab.
            //To start this class right click the project and select properties.
            //Select the application option and set the start up to object to this class example found here.


            //  Write a program that will prompt the user to enter in the message
            //  "Mary had a little lamb"
            Console.WriteLine("Mary had a little lamb");
            //  replace all the white space in the message with a , promgramatically and print the result to the console.
            string msg = "Mary had a little lamb";
            string msgWithComma = msg.Replace(" ", ",");
            Console.WriteLine($"Updated Message with commas : {msgWithComma}");

            //Expected output
            // Mary,had,a,little,lamb


            // Next print the orignal message without white space
            // Expected output:
            //      Maryhadalittlelamb
            string msgWithNoSpace = msg.Replace(" ", "");
            Console.WriteLine($"Updated Message with no spaces : {msgWithNoSpace}");


            //Prompt the user to enter their first name

            //Next, create a formattable string that will let you change names based on the user input
            //      expected output if the variable contained the name Seth
            //      Seth had a little lamb.

            Console.WriteLine("Enter Your First Name : ");
            string newName = Console.ReadLine();
            String newMsg = msg.Replace("Mary", newName);
            Console.WriteLine($"Updated msg : {newMsg}");

            // Print the original message in all capitals.
            Console.WriteLine($"Upper case msg : {msg.ToUpper()}");
            // Print the original message in lower case.
            Console.WriteLine($"Lower case msg : {msg.ToLower()}");

            //Print the length of the original string to the console.
            Console.WriteLine($"Length of msg : {msg.Length}");

            //Combine the original message with a new message and then display to the console
            //Ex: Mary had a little lamb who's fleece was white as snow
            Console.WriteLine("Enter additional message : ");
            string msg2=Console.ReadLine();
            msg = msg.Insert(msg.Length, " ");
            msg = msg.Insert(msg.Length, msg2);
            Console.WriteLine($"Upadted msg : {msg}");
            Console.ReadLine();
        }

   }
}
