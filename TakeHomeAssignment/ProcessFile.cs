using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FuzzySharp;

namespace TakeHomeAssignment;

public class ProcessFile
{
    //creates a new array of duplicate strings
    public static List<string> FindDuplicates(List<string> inputArray, int threshold)
    {
        // loop through array with a string to compare, use fuzzy comparison function
        // if the comparison results in a high likelihood of a duplicate
            //stop the loop, add the comparison string to a result array and remove the second comparison string
            //so it isn't iterated over twice unnecessarily
            
        List<string> result = new List<string>();
            
            for (int i = 0; i < inputArray.Count; i++)
            {
                string currentString = inputArray[i];
                Console.Write($"current string: {currentString}");

                for (int j = i + 1; j < inputArray.Count; j++)
                {
                    string stringToCompare = inputArray[j];

                    int fuzziness = Fuzz.Ratio(currentString, stringToCompare);

                    if (fuzziness >= threshold)
                    {
                        result.Add(currentString);
                        inputArray.RemoveAt(j);
                        j--;
                        Console.WriteLine($"\n FOUND FUZZINESS: {stringToCompare}");
                        break;
                    }
                }
            }
            return result;
    }
}