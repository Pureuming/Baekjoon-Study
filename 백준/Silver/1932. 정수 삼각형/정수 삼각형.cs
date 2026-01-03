using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());
        
        int[,] dp = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            int[] arr = sr.ReadLine().Split().Select(int.Parse).ToArray();

            if (i == 0)
            {
                dp[0, 0] = arr[0];
            }
            else
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {
                        dp[i, j] = dp[i - 1, j] + arr[j];
                    }
                    else if (j == i)
                    {
                        dp[i, j] = dp[i - 1, j - 1] + arr[j];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j - 1], dp[i - 1, j]) + arr[j];
                    }
                }
            }
        }

        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (dp[n - 1, i] > max)
                max = dp[n - 1, i];
        }
        
        sw.Write(max);
    }
}