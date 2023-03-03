using System;
using System.Collections.Generic;

public class program
{
    public static void mergeArrays(int[] arr1, int[] arr2, int n1, int n2)
    {
        int i = 0;
        int j = 0;
        int k = 0;
        int[] arr3 = new int[n1 + n2];
        while (i < n1)
        {
            arr3[k++] = arr1[i++];
        }

        while (j < n2)
        {
            arr3[k++] = arr2[j++];
        }


        Array.Sort(arr3);
        for (int a = 0; a < n1 + n2; a++)
            Console.Write(arr3[a] + " ");
    }

    public static void Main(string[] args)
    {
        int n1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n1];

        for (int i = 0; i < n1; i++)
           arr1[i]=Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[n2];
        for (int i = 0; i < n2; i++)
            arr2[i] = Convert.ToInt32(Console.ReadLine());


        mergeArrays(arr1, arr2, n1, n2);
        Console.ReadKey();
        
    }
}