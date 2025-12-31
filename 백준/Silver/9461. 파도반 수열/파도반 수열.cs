using System.IO;
using System.Text;

class Backjoon
{        
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        
        int t = int.Parse(sr.ReadLine());

        long[] dp = new long[101];

        dp[1] = 1;
        dp[2] = 1;

        for (int i = 3; i <= 100; i++)
        {
            dp[i] = dp[i - 3] + dp[i - 2];
        }

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(sr.ReadLine());

            sb.AppendLine(dp[n].ToString());
        }
        
        sw.Write(sb);
    }
}