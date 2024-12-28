using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using FuzzySharp;
using System.Threading;

namespace TakeHomeAssignment;
class Program
{
    private static string _inputFilePath;
    private static int _threshold;
    private static string _outputFilePath;

    // Takes a .txt file of strings separated by a new line and returns potential duplicates as a txt file
    static void Main(string[] args)
    {
        
        //read the file
        Console.WriteLine("Enter the file path:");
        _inputFilePath = Console.ReadLine();
        
        //returns an array of strings to be processed
        List<string> linesArray = FileReader.CreateArrayFromFile(_inputFilePath);
        
        _threshold = 90;
        
        //process the lines
        
        Console.WriteLine("Finding Duplicates, this may take a few minutes.");
        List<string> duplicates = ProcessFile.FindDuplicates(linesArray, _threshold);
        
        
        //produce a file of duplicates
        
        Console.WriteLine("Enter the output file path: ");
        _outputFilePath = Console.ReadLine();
        
        FileWriter.WriteToFile(duplicates, _outputFilePath);
    }
}