using System;

class Program
{
    static int Thirdlargest(int[] arr, int n)
    {
        int first = int.MinValue;
        int second = int.MinValue;
        int third = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)
            {
                third = second;
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                third = second;
                second = num;
            }
            else if (num > third && num != second && num != first)
            {
                third = num;
            }
        }
        return third;
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int index = Thirdlargest(arr, n);
        Console.WriteLine(index);
    }
}
