using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FuzzySharp;

namespace TakeHomeAssignment;

public class ProcessFile
{
    //creates a new array of duplicate strings from array created from the input file
    //uses the fuzzyWuzzy (fuzzySharp) library for comparison, which in turn uses the Levenshtein algorithm for a comparison score
    //FuzzySharp Nuget https://www.nuget.org/packages/FuzzySharp#readme-body-tab
    
    public static List<string> FindDuplicates(List<string> inputArray, int threshold)
    {
            
        
        //sort the list alphabetically as duplicates will probably have similar starting characters
        inputArray.Sort();
            
        List<string> result = new List<string>();
        
        //so indices won't get processed twice they are stored in this HashSet
        HashSet<int> processedIndices = new HashSet<int>();
            
            //Some inspiration for this from this SO thread
            //https://stackoverflow.com/questions/18916396/trying-to-optimise-fuzzy-matching
            for (int i = 0; i < inputArray.Count; i++)
            {
                if (processedIndices.Contains(i)) continue;
                
                string currentString = inputArray[i];

                for (int j = i + 1; j < inputArray.Count; j++)
                {
                    if (processedIndices.Contains(j)) continue;
                    string stringToCompare = inputArray[j];
                    
                    //There is a list of different methods in the library to test fuzziness ratio
                    //tried a couple different methods. Didn't test them all extensively.
                    //this one seemed "good enough" 
                    int fuzziness = Fuzz.Ratio(currentString, stringToCompare);

                    //threshold I am using is 90
                    if (fuzziness >= threshold)
                    {
                        result.Add(currentString);
                        processedIndices.Add(j);
                        Console.WriteLine("Found duplicate for " + stringToCompare);
                        break;
                    }
                }
            }
            return result;
    }
}