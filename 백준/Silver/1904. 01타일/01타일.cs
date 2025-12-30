using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());

        int[] dp = new int[n + 1];
        
        dp[1] = 1;
        if (n > 1)
            dp[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = (dp[i - 1] + dp[i - 2]) % 15746;
        }
        
        sw.Write(dp[n]);
    }
}