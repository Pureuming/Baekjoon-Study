using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        string[] input = sr.ReadLine().Split();
        int k = int.Parse(input[0]);
        int n = int.Parse(input[1]);
        int[] arr = new int[k];
        int max = 0;
        for (int i = 0; i < k; i++)
        {
            arr[i] = int.Parse(sr.ReadLine());
            if (arr[i] > max) max = arr[i];
        }
        
        sw.Write(Binary(arr, n, max));
    }

    static long Binary(int[] arr, int num, int max)
    {
        long low = 1;
        long high = max;
        long result = 0;

        while (low <= high)
        {
            long mid = (low + high) / 2;
            long sum = 0;

            foreach (var len in arr)
            {
                sum += len / mid;
            }

            if (sum >= num)
            {
                low = mid + 1;
                result = mid;
            }
            else
                high = mid - 1;
        }

        return result;
    }
}