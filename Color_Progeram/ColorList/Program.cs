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

            //adding list of colors in to Color list collection
            Colors.Add("White");
            Colors.Add("Red");
            Colors.Add("Orange");
            Colors.Add("Yellow");
            Colors.Add("Green");
            Colors.Add("Blue");
            Colors.Add("Indigo");
            Colors.Add("Violet");
            Colors.Add("Black");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            //listing of color items in the list
            Console.WriteLine("list of colors in the Colors list is:\n");
            foreach (string color in Colors)
            {
                Console.WriteLine("    " + color);
            }
            Console.WriteLine("-------------------------------------------\n");

            //counting the number of items in the Color list
            int numberOfItem = Colors.Count;
            Console.WriteLine("The Colors list has {0} items",numberOfItem);
            Console.WriteLine("-------------------------------------------\n");

            //Sorting the list
            Colors.Sort();

            Console.WriteLine("The sorted list of colors in the Colors list is:\n ");
            foreach (string color in Colors)
            {
                Console.WriteLine("    " + color);
            }
            Console.WriteLine("-------------------------------------------\n");

            //finding the index number of the list
            int index = Colors.IndexOf("Violet");
            Console.WriteLine("The index number of Violet color in the list is: {0}", index);
            Console.WriteLine("-------------------------------------------\n");

            //removing a single item from the list
            Colors.Remove("Violet");

            //Inserting a single item in the specified location
            Colors.Insert(7,"Purple");
            //....................................................................................................
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
