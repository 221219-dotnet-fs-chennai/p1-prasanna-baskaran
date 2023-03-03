using System;

public class Class1
{
    public static void RotateArrayLeft(int[] arr, int d)
    {
        int n = arr.Length;
        d %= n;
        ReverseArray(arr, 0, d - 1);
        ReverseArray(arr, d, n - 1);
        ReverseArray(arr, 0, n - 1);
    }

    private static void ReverseArray(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        RotateArrayLeft(arr, n);
        Console.ReadKey();
        
    }
}
