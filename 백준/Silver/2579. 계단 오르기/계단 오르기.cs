using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());
        
        int[] dp = new int[n + 1];
        int[] scores = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            scores[i] = int.Parse(sr.ReadLine());
        }

        dp[1] = scores[1];
        if (n > 1)
            dp[2] = dp[1] + scores[2];

        for (int i = 3; i <= n; i++)
        {
            dp[i] = Math.Max(dp[i - 2], dp[i - 3] + scores[i - 1]) + scores[i];
        }
        
        sw.Write(dp[n]);
    }
}