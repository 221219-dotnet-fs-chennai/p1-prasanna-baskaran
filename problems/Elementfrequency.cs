using System;

class Program
{
    public static void countFreq(int[] arr, int n)
    {
        bool[] visited = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (visited[i] == true)
                continue;

            int count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    visited[j] = true;
                    count++;
                }
            }
            Console.WriteLine(arr[i] + " " + count);
        }
    }

    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for(int i=0;i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        countFreq(arr, n);
    }
}
