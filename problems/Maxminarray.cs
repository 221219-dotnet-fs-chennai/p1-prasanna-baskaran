using System;
public class program
{
    public static void Main()
    {

        
        int i, mx, mn, n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n];
        for (i = 0; i < n; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }


        mx = arr1[0];
        mn = arr1[0];

        for (i = 1; i < n; i++)
        {
            if (arr1[i] > mx)
            {
                mx = arr1[i];
            }


            if (arr1[i] < mn)
            {
                mn = arr1[i];
            }
        }
        Console.Write(mx+", "+ mn);
    }
}
