using System;

public class Class1
{
    static int[] FindMaxProductTriplet(int[] arr)
    {
        int n = arr.Length;

        if (n < 3)
        {
            throw new ArgumentException("Array should have at least 3 elements");
        }

        // Initialize the maximum product triplet
        int[] maxTriplet = { arr[0], arr[1], arr[2] };

        // Traverse through the array and update the maximum product triplet
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    int tripletProduct = arr[i] * arr[j] * arr[k];

                    if (tripletProduct > maxTriplet[0] * maxTriplet[1] * maxTriplet[2])
                    {
                        maxTriplet[0] = arr[i];
                        maxTriplet[1] = arr[j];
                        maxTriplet[2] = arr[k];
                    }
                }
            }
        }

        return maxTriplet;
    }
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int []arr1=FindMaxProductTriplet(arr);
        Console.WriteLine("The triplet having the maximum product in arr2 is ({0}, {1}, {2})", arr1[0], arr1[1], arr1[2]);
        Console.ReadKey();

    }
}
