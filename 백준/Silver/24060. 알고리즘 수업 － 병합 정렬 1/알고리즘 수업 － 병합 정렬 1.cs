using System.IO;

class Backjoon
{
    static int[] temp;
    static int k;
    static int count = 0;
    static int result = -1;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        k = int.Parse(input[1]);
        
        int[] arr = sr.ReadLine().Split().Select(int.Parse).ToArray();
        temp = new int[n];
        
        MergeSort(arr, 0, n - 1);

        sw.Write(result);
    }

    static void MergeSort(int[] A, int p, int r)
    {
        if (p < r)
        {
            int q = (p + r) / 2;

            MergeSort(A, p, q);
            MergeSort(A, q + 1, r);
            Merge(A, p, q, r);
        }
    }

    static void Merge(int[] A, int p, int q, int r)
    {
        int i = p;	
        int j = q + 1;
        int t = 0;

        while (i <= q && j <= r)
        {
            if (A[i] <= A[j])
            {
                temp[t++] = A[i++];
            }
            else
            {
                temp[t++] = A[j++];
            }
        }

        while (i <= q)
        {
            temp[t++] = A[i++];
        }

        while (j <= r)
        {
            temp[t++] = A[j++];
        }

        i = p;
        t = 0;

        while (i <= r)
        {
            count++;
            A[i++] = temp[t++];

            if (count == k)
                result = temp[t - 1];
        }
    }
}