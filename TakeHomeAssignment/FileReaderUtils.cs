using System;
using System.IO;

namespace TakeHomeAssignment;

public class FileReaderUtils
{
    //removes the trailing slashes so those aren't counted as fuzzy similarities during processing
    public static string CleanLines(string line)
    {
        if (!string.IsNullOrEmpty(line))
        {
            string cleanLine = line.TrimEnd('\\'); 
            return cleanLine;
        }
        return line;
    }
    //TODO
    //further cleaning of the lines by removing common strings like "ltd, llc, inc" etc. 
    //this will make the processing for similarities more accurate and faster
}