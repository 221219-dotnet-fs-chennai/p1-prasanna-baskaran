using System;

public class Program
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false; // if the lengths of s and t are different, they can't be anagrams
        }
        int[] charCount = new int[26]; // count of each character
        for (int i = 0; i < s.Length; i++)
        {
            charCount[s[i] - 'a']++;
            charCount[t[i] - 'a']--;
        }
        for (int i = 0; i < charCount.Length; i++)
        {
            if (charCount[i] != 0)
            {
                return false; // if any count is non-zero, s and t are not anagrams
            }
        }
        return true; // if all counts are zero, s and t are anagrams
    }

    public static void Main()
    {
        string s1 = Console.ReadLine();
            string t1 =Console.ReadLine();
        Console.WriteLine( IsAnagram(s1, t1));
        Console.ReadKey();
    }
}