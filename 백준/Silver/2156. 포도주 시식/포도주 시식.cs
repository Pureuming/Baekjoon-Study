using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());

        int[] dp = new int[n + 1];
        int[] glasses = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            glasses[i] = int.Parse(sr.ReadLine());
        }

        dp[1] = glasses[1];
        if (n > 1)
            dp[2] = glasses[1] + glasses[2];

        for (int i = 3; i <= n; i++)
        {
            int a = dp[i - 1];
            
            int b = dp[i - 2] + glasses[i];
            
            int c = dp[i - 3] + glasses[i - 1] + glasses[i];

            dp[i] = Math.Max(a, Math.Max(b, c));
        }
        
        sw.Write(dp[n]);
    }
}