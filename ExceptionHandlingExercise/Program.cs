using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // DONE--First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // DONE--Create a list called numbers that will hold integers
            // DONE--Create a string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[] { '6', '5', '4', '3', '2', '1', 'A', 'B', 'C' };
            var numbers = new List<int>();
            string str = string.Empty;

            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (var num in arr)
            {
                // Now create a try catch
                try
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list
                    str = num.ToString();
                    int number = int.Parse(str);
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    // catch your Exception:
                    // in the scope of your catch you can use the following, 

                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

                    Console.WriteLine($"Unable to parse '{num}'.");
                    Console.WriteLine(e.GetType());
                    
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Numbers");
            Console.WriteLine("-------");
            Console.WriteLine("");

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
