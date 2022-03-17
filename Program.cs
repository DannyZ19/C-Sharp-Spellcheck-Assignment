// Spell Check Starter
// This start code creates two lists
// 1: dictionary: an array containing all of the words from "dictionary.txt"
// 2: aliceWords: an array containing all of the words from "AliceInWonderland.txt"

using System;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        // Load data files into arrays
        String[] dictionary = System.IO.File.ReadAllLines(@"data-files/dictionary.txt");
        String aliceText = System.IO.File.ReadAllText(@"data-files/AliceInWonderLand.txt");
        String[] aliceWords = Regex.Split(aliceText, @"\s+");



        // Print first 50 values of each list to verify contents
        Console.WriteLine("***DICTIONARY***");
        printStringArray(dictionary, 0, 50);

        Console.WriteLine("***ALICE WORDS***");
        printStringArray(aliceWords, 0, 50);

        Console.WriteLine("\n1. Linear Search");
        Console.WriteLine("\n2. Binary Search");

        Console.WriteLine("\nPlease select which search algorithm to use.");
        var selection = Console.ReadLine();
        if (selection == "1")
        {
            Console.WriteLine("Linear Search");

            Console.WriteLine("Please select a word to search for.");
            string item = Console.ReadLine();
            for (int i = 0; i < 1; i++)
            {
                if (item == dictionary[i])
                {
                    Console.WriteLine("\nWord found");
                    
                } else
                {
                    Console.WriteLine("\nnot found");
                }
            }




        }


       
    }



    public static void printStringArray(String[] array, int start, int stop)
    {
        // Print out array elements at index values from start to stop 
        for (int i = start; i < stop; i++)
        {
            Console.WriteLine(array[i]);
        }
    }






}
