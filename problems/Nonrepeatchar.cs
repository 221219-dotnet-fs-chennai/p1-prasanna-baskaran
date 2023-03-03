using System;

public class Program
{
    public static int FirstNonRepeatingChar(string s)
    {
        int[] charCount = new int[26]; // count of each character
        for (int i = 0; i < s.Length; i++)
        {
            charCount[s[i] - 'a']++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i] - 'a'] == 1)
            {
                return i;
            }
        }
        return -1; // if no non-repeating character found
    }

    public static void Main()
    {
        string s =Console.ReadLine();
        int index = FirstNonRepeatingChar(s);
        if (index == -1)
        {
            Console.WriteLine("No non-repeating character found");
        }
        else
        {
            Console.WriteLine("Index of first non-repeating character: " + index);
        }
    }
}
