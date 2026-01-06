using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());

        int[] dp = new int[n + 1];

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + 1;
            
            if (i % 3 == 0)
                dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
            
            if (i % 2 == 0)
                dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
        }
        
        sw.Write(dp[n]);
    }
}