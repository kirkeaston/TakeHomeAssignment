using System;
using System.IO;

namespace TakeHomeAssignment;

public class FileReader
{
    //reads the input file and returns an array of strings on every new line
    public static List<string> CreateArrayFromFile(string inputFilePath)
    {
        try
        {
            if (File.Exists(inputFilePath))
            {
                var lines = new List<string> (File.ReadAllLines(inputFilePath));
                Console.WriteLine("reading content");
                return lines;
            }
            else
            {
                Console.WriteLine("File not found");
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