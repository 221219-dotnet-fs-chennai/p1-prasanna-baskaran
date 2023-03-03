using System;

public class Class1
{
    string RemoveVowels(string str)
    {
        string vowels = "aeiouAEIOU";
        StringBuilder result = new StringBuilder();

        foreach (char c in str)
        {
            if (!vowels.Contains(c))
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
    static void Main(string[] args)
    {
        string a=Console.ReadLine();
        string b=RemoveVowels(a);
        Console.WriteLine(b);
    }
}
