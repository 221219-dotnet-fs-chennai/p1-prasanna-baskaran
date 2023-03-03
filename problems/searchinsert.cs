using System;

class Program
{
    static int SearchInsertIndex(int[] arr, int n, int k)
    {
        int low = 0, high = n - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == k)
                return mid;
            else if (arr[mid] > k)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return low;
    }

    static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
         int k= Convert.ToInt32(Console.ReadLine());
        int index = SearchInsertIndex(arr, n, k);
        Console.WriteLine(index);
    }
}