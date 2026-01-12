using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());

        int[] incDp = new int[n + 1];
        int[] decDp = new int[n + 1];
        int[] arr = new int[n + 1];

        string[] input = sr.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            arr[i] = int.Parse(input[i - 1]);
            incDp[i] = 1;
            decDp[i] = 1;
        }

        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                if (arr[i] > arr[j])
                {
                    incDp[i] = Math.Max(incDp[i], incDp[j] + 1);
                }
            }
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = i + 1; j <= n; j++)
            {
                if (arr[i] > arr[j])
                {
                    decDp[i] = Math.Max(decDp[i], decDp[j] + 1);
                }
            }
        }

        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            result = Math.Max(result, incDp[i] + decDp[i] - 1);
        }
        
        sw.Write(result);
    }
}