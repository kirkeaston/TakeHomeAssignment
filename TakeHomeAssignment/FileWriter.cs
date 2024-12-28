using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FuzzySharp;

namespace TakeHomeAssignment;

public class FileWriter
{
    public static void WriteToFile(List<string> dupes, string filePath)
    {
        try
        {
            if (dupes == null || dupes.Count == 0)
            {
                Console.WriteLine(
                    "No dupes were provided, so something went terribly wrong and I'm sorry but you will never get that time back.");
                return;
            }

            File.WriteAllLines(filePath, dupes);
            Console.WriteLine($"File written to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"There was an error, here it is: {ex.Message}");
        }
    }
    
}