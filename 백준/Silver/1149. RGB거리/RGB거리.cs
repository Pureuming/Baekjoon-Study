using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());
        
        int[,] dp = new int[n, 3];

        for (int i = 0; i < n; i++)
        {
            int[] arr = sr.ReadLine().Split().Select(int.Parse).ToArray();

            if (i == 0)
            {
                for (int j = 0; j < 3; j++)
                {
                    dp[0, j] = arr[j];
                }
            }
            else
            {
                dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + arr[0];
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + arr[1];
                dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + arr[2];
            }
        }

        int min = int.MaxValue;
        for (int i = 0; i < 3; i++)
        {
            if (dp[n - 1, i] < min)
                min = dp[n - 1, i];
        }
        
        sw.Write(min);
    }
}