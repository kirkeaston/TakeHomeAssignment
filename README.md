# TakeHomeAssignment

## What I Came Up With:

It's a console app where you input a file path to the new line separated values of strings you want to compare to find duplicates, it reads the file into an array, it processes the array to find duplicates, and then you input a filepath where you would like the results of the duplicates stored. 

## Technologies used:

It's a C# console app, in which I used a C# nuget package called fuzzySharp which is an adaptation of the fuzzyWuzzy python library that SeatGeek open sourced in 2011. I used the Fuzz.Ratio method from this package to determine the similarity coefficient between two strings. 

## Things I would do differently if I had more time:

- ability to fetch the input text from the s3 bucket that you provided rather than having the necessity for you to provide an input file path from something stored locally.
- ability to add different formats of input data (.csv would be useful)
- more cleaning of the input before processing to increase processing speed. Some Regex to remove common parts of company names that don't help in determining similarity (llc, inc, .com) would make the algorithm process much quicker.
- multi threading, breaking the one large task into smaller similar tasks being run simultaneously on several virtual machines would speed up processing. Several SO posts mentioned this as the best way to increase processing for large datasets
- giving options for delivery of the results rather than just an output file path for local storage (google docs, UI)
- testing different fuzz methods: the process.ExtractAll method in fuzzySharp might have been a better option but required more configuration. I only tried the fuzz.Weighted and fuzz.PartialRatio before settling on Fuzz.Ratio as the method to determine the similarity coefficient.
- testing different algorithms: I found a lot of support for the Jaro-Winkler distance algorithm online. Didn't try anything but Levenshtein, but I am curious if it is the most efficient or if there is a better method.
- Writing unit tests.
- I would experiment with blocking pieces of each string to be used instead of the entire string as most of the differences between companies seemed to be within the first few characters. This was probably possible using one of the FuzzySharp "token" methods, but required more configuration so I didn't bother with testing if that significantly increased processing
- a number of the fuzzySharp methods included a "pre-processing" parameter. This defaulted to trimming, toLower-ing, and removing punctuation by default. However, it included a factory in which you could create custom pre-processors which might have been useful if I had more time to set this parameter specifically for the use case at hand

## In Conclusion:

It works but has some serious improvement potential. 

Thank you again for such a fun assignment, I much prefer this to the HackerRank assessments I have been assigned repeatedly over the job search. Thank you for taking to time to look at this. I hope you have a great rest of your day and best of luck in your hiring journey!

Best wishes,

Kirk
