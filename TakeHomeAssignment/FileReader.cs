using System;
using System.IO;

namespace TakeHomeAssignment;

public class FileReader
{
    //reads the input file and returns an array of strings on every new line
    public static string[]  CreateArrayFromFile(string inputFilePath)
    {
        try
        {
            if (File.Exists(inputFilePath))
            {
                string[] lines = File.ReadAllLines(inputFilePath);
                Console.WriteLine("reading content");
                return lines;
            }
            else
            {
                Console.WriteLine("File not found");
                return Array.Empty<string>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred: {ex.Message}");
            return Array.Empty<string>();
        }
    }
    
}