using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FuzzySharp;

namespace TakeHomeAssignment;
class Program
{
    private static string _filePath;
    private static int _threshold;

    // Takes a .txt file of strings separated by a new line and returns potential duplicates
    static void Main(string[] args)
    {
        
        //read the file
        Console.WriteLine("Enter the file path:");
        _filePath = Console.ReadLine();
        
        //returns an array of strings to be processed
        List<string> linesArray = FileReader.CreateArrayFromFile(_filePath);
        
        //ask what the similarity threshold they would like to be
        Console.WriteLine("Enter the threshold:");
        _threshold = int.Parse(Console.ReadLine());
        
        //process the lines
        
        List<string> duplicates = ProcessFile.FindDuplicates(linesArray, _threshold);

        foreach (string duplicate in duplicates)
        {
            Console.WriteLine(duplicate);
        }
        //produce a file of duplicates
        
    }
}