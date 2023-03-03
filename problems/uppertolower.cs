using System;

class Program
{
    static string ReplaceUppercaseWithLowercase(string s)
    {
        string result = "";
        foreach (char c in s)
        {
            if (Char.IsUpper(c))
            {
                result += Char.ToLower(c);
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = ReplaceUppercaseWithLowercase(s);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    
}
