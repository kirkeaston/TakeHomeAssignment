using System;
using System.IO;

namespace TakeHomeAssignment;

public class FileReader
{
    //reads the input file and returns an array of strings on every new line
    //call a util function that cleans the line before processing
    //If no file is found on the file path input it exits the program 
    public static List<string> CreateArrayFromFile(string inputFilePath)
    {
        try
        {
            if (File.Exists(inputFilePath))
            {
                string[] lines = File.ReadAllLines(inputFilePath);
                Console.WriteLine("reading content");
                List<string> processedLines = new List<string>();
                foreach (string line in lines)
                {
                    processedLines.Add(FileReaderUtils.CleanLines(line));
                }
                return processedLines;
            }
            else
            {
                Console.WriteLine("File not found");
                System.Environment.Exit(0);
                return new List<string>(Array.Empty<string>());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred: {ex.Message}");
            return new List<string>(Array.Empty<string>());
        }
    }
    
}