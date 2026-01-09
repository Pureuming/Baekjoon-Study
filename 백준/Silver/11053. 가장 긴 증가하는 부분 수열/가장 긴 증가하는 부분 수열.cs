using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());

        int[] dp = new int[n + 1];
        int[] arr = new int[n + 1];

        string[] input = sr.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            arr[i] = int.Parse(input[i - 1]);
            dp[i] = 1;
        }

        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                if (arr[i] > arr[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            result = Math.Max(result, dp[i]);
        }
        
        sw.Write(result);
    }
}