using System;

class Program
{
    static int removeDuplicates(int[] arr, int n)
    {
        if (n == 0 || n == 1)
            return n;

        int[] temp = new int[n];
        int j = 0;

        for (int i = 0; i < n - 1; i++)
            if (arr[i] != arr[i + 1])
                temp[j++] = arr[i];
        temp[j++] = arr[n - 1];
        for (int i = 0; i < j; i++)
            arr[i] = temp[i];

        return j;
    }

    public static void Main()
    {
        int n=Convert.ToInt32 (Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i]=Convert.ToInt32(Console.ReadLine());

        n = removeDuplicates(arr, n);

        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }
}
