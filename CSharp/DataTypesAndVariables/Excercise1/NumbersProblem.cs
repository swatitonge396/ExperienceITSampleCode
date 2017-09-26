using System.Collections.Generic;
using System;

namespace DataTypesAndVariables.Excercise1
{
    public class NumbersProblem
    {

        public static void Main()
        {
            // Create a program that will do the following and write all results to the console

            //Add two ints 

            //Subtract to ints

            //multiply two ints 

            //Divide two ints 

            //Mod two ints.

            //print the results of each

            int n1, n2;
            n1 = 2; n2 = 4;
            Console.WriteLine("{0} + {1} = {2} ", n1, n2, n1 + n2);
            Console.WriteLine("{0} - {1} = {2} ", n1, n2, n1 - n2);
            Console.WriteLine("{0} * {1} = {2} ", n1, n2, n1 * n2);
            Console.WriteLine("{0} / {1} = {2} ", n1, n2, n1 / n2);
            Console.WriteLine("{0} % {1} = {2} ", n1, n2, n1 % n2);

            //print the minvalue of an int using the min value method
            Console.WriteLine("minimum number among {0} , {1}  is {2} ", n1, n2, n1 < n2 ? n1 : n2);

            //print the maxvalue of an int using the max value method
            Console.WriteLine("maximum number among {0} , {1}  is {2} ", n1, n2, n1 > n2 ? n1 : n2);

            //Add two doubles together
            //Subtract to doubles 
            //multiply two doubles 
            //Divide two doubles 
            //Mod two doulbes.
            //print the results of each displaying two decimal places
            //print the results of each diplaying 4 decimal places
            //print the max value of a double
            //print the min value of a double

            double n3, n4;
            n3 = 2.3;
            n4 = 3.2;
            Console.WriteLine("{0} + {1} = {2:0.00} ", n3, n4, n3 + n4);
            Console.WriteLine("{0} - {1} = {2:0.00} ", n3, n4, n3 - n4);
            Console.WriteLine("{0} * {1} = {2:0.00} ", n3, n4, n3 * n4);
            Console.WriteLine("{0} / {1} = {2:0.00} ", n3, n4, n3 / n4);
            //Console.WriteLine("{0} + {1} = {2:0.0000} ", n3, n4, n3 + n4);
            Console.WriteLine("{0} - {1} = {2:0.0000} ", n3, n4, n3 - n4);
            Console.WriteLine("{0} * {1} = {2:0.0000} ", n3, n4, n3 * n4);
            Console.WriteLine("{0} / {1} = {2:0.0000} ", n3, n4, n3 / n4);
            Console.WriteLine("minimum number among {0} , {1}  is {2} ", n3, n4, n3 < n4 ? n3 : n4);
            Console.WriteLine("minimum number among {0} , {1}  is {2} ", n3, n4, n3 < n4 ? n3 : n4);

            //divide an int value by a double and capture the value and then print the result;
            //todo: decimal manipulation 
            // int and decimal/double result
            // add max value of int to max value of int and print the result as int
            // same as double and decimal
            Console.WriteLine("{0} / {1} = {2:0} ", n1, n4, n1 / n4);
            Console.WriteLine($"{n1} / {n4} = {n1 / n4} ");


            //BOOL and OBJect class problems will neede to be created.
            bool flag = true;
            object o;
            o = n1; //boxing
            Console.WriteLine($"Flag is {flag}");
            Console.WriteLine($"Object is {o}");
            Console.WriteLine($"type of flag is {flag.GetType().ToString()}");

            Console.ReadLine();
        }

        //}
    }
}
