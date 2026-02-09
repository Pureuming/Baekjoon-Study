using System.IO;

class Backjoon
{
    static long MOD = 1000000007;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        
        long[] dp = new long[n + 1];
        dp[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            dp[i] = (dp[i - 1] * i) % MOD;
        }

        long numerator = dp[n];
        long denominator = (dp[k] * dp[n - k]) % MOD;
        
        sw.Write(numerator * Power(denominator, MOD - 2) % MOD);
    }

    static long Power(long baseValue, long exp)
    {
        long result = 1;
        baseValue %= MOD;

        while (exp > 0)
        {
            if (exp % 2 == 1)
                result = (result * baseValue) % MOD;
            
            baseValue = (baseValue * baseValue) % MOD;
            exp /= 2;
        }

        return result;
    }
}