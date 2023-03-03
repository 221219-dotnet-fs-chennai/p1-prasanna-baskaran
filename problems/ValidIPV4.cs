using System;

class MainClass
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int n = str.Length;
        int lCount = 0; // Count of 'L' characters
        int rCount = 0; // Count of 'R' characters
        int maxCount = 0; // Maximum number of balanced substrings

        for (int i = 0; i < n; i++)
        {
            if (str[i] == 'L')
            {
                lCount++;
            }
            else
            {
                rCount++;
            }

            // If number of 'L' and 'R' characters are equal, we have found a balanced substring
            if (lCount == rCount)
            {
                maxCount++;
            }
        }

        Console.WriteLine(maxCount); // Output the maximum number of balanced substrings
    }
}




