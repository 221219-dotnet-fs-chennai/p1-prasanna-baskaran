using System;
class program
{
    static void chkPair(int[] A, int size, int x)
    {
        for (int i = 0; i < (size - 1); i++)
        {
            for (int j = (i + 1); j < size; j++)
            {
                if (A[i] + A[j] == x)
                {
                    Console.WriteLine("[" + A[i]+","+A[j]+"]");
                }
            }
        }

        Console.WriteLine("NULL");
    }

    public static void Main()
    {
        int x=Convert.ToInt32(Console.ReadLine()); 
        int n= Convert.ToInt32(Console.ReadLine());
        int[] A = new int[n];
        for(int i = 0; i < n; i++)
        {
            A[i]= Convert.ToInt32(Console.ReadLine());
        }

        chkPair(A, size, x);
        Console.ReadKey();
        
    }
}
