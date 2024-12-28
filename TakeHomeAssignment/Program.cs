using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FuzzySharp;

namespace TakeHomeAssignment;
class Program
{
    private static string _filePath;

    // Takes a .txt file of strings separated by a new line and returns potential duplicates
    static void Main(string[] args)
    {
        
        //read the file
        Console.WriteLine("Enter the file path:");
        _filePath = Console.ReadLine();
        
        //returns an array of strings to be processed
        string[] linesArray = FileReader.CreateArrayFromFile(_filePath);
        
        //process the lines
        
        //produce a file of duplicates
        
    }
}