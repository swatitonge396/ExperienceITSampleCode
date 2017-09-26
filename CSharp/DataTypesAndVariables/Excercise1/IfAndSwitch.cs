using System.Collections.Generic;
using System;
namespace DataTypesAndVariables.Excercise1
{
    public class IfAndSwitch
    {
        public static void Main(string[] args)
        {
            //if statements, if else, else
            //switch statement

            //Write a program using if statements that when given an integer between 0 and 100 returns
            //the letter grade A, B, C, D, or F
            //0-60 receives a F
            //61-70 receives a D
            //71-80 recieves a C
            //81-90 recieves a B
            //91-100 recieves an A
            //If they provide anything else, return ERR

            //Console.WriteLine($"Your letter grade is {letterGrade}");
            string marks;
            int intMarks;
            
            Console.WriteLine("Enter marks (0-100) :");
            marks = Console.ReadLine();
            int.TryParse(marks,out intMarks);

            if (intMarks > 100 || intMarks < 0)
                Console.WriteLine("ERR");
            else if (intMarks >90 )
                Console.WriteLine("You have got A");
            else if (intMarks > 80)
                Console.WriteLine("You have got B");
            else if (intMarks > 70)
                Console.WriteLine("You have got C");
            else if (intMarks > 60)
                Console.WriteLine("You have got D");
                else
                Console.WriteLine("You have got E");







            //Write a program using a switch statement that takes in a string letter grade and returns an int value
            //A = 95
            //B = 85
            //C = 75
            //D = 65
            //F = 0
            //anything else return -1

            //Console.WriteLine($"Your numeric grade is {numericGrade}");
            string letterGrade;
            int numericGrade;
            Console.WriteLine("Enter your Grade (A-F) :");
            letterGrade=Console.ReadLine();
            switch(letterGrade.ToUpper())
            {
                case "A":
                    numericGrade = 95;
                    break;
                case "B":
                    numericGrade = 85;
                    break;
                case "C":
                    numericGrade = 75;
                    break;
                case "D":
                    numericGrade = 65;
                    break;
                case "F":
                    numericGrade = 0;
                    break;
                default :
                    numericGrade =-1;
                    break;
            }
            Console.WriteLine($"Your numeric grade is {numericGrade}");
            Console.ReadKey();
        }
    }
}
