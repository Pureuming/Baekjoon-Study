using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());
        int[] arr = sr.ReadLine().Split().Select(int.Parse).ToArray();

        int[] dp = new int[n];
        dp[0] = arr[0];
        int max = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (dp[i - 1] >= 0)
            {
                dp[i] = dp[i - 1] + arr[i];
            }
            else
            {
                dp[i] = arr[i];
            }
            
            if (dp[i] > max) max = dp[i];
        }
        
        sw.Write(max);
    }
}