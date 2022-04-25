/********

** Name: Shewarade, Yared
** Class: CS 132
** Project: PE10_02
** Date: 2021-03-15
** Description: The list methods of list collection project.
** This project uses different list method on the list object.
** Add() method adds item at the end of the list where as Insert() method places the item at the 
** specified location of the list using index, and it needs to pass two parameters.

********/
using System;
using System.Collections.Generic;

namespace ColorList
{
    class Program
    {
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            //creating string list of colors
            List<string> Colors = new List<string>();

            //Listing all colors from the Color list collection
            Console.WriteLine("Finally, the list of colors available in the Colors list is:\n ");
            foreach (string color in Colors)
            {
                Console.WriteLine("    " + color);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("\nThere two questions in the programming exercise 10_02 which is:\n");
            Console.WriteLine("  Where did Add() method place Magenta in the list? Why do we need an insert() method?");
            Console.WriteLine("          ......................................................");
            Console.WriteLine("\n The possible answer would be:\n");
            Console.WriteLine("  ** Add() method places the item at the end of the list. ");
            Console.WriteLine("  ** We need insert() method to insert item at the specific location of list using index");
            Console.WriteLine("\n================================================================================");
            Console.ReadLine();

        }
    }
}
