using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());

        long[,] dp = new long[n + 1, 10];
        int divNum = 1000000000;

        for (int i = 1; i <= 9; i++)
        {
            dp[1, i] = 1;
        }

        for (int i = 2; i <= n; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                if (j == 0)
                    dp[i, j] = dp[i - 1, j + 1] % divNum;
                else if (j == 9)
                    dp[i, j] = dp[i - 1, j - 1] % divNum;
                else
                    dp[i, j] = (dp[i - 1, j - 1] + dp[i - 1, j + 1]) % divNum;
            }
        }

        long result = 0;
        for (int i = 0; i <= 9; i++)
        {
            result = (result + dp[n, i]) % divNum;
        }
        
        sw.Write(result);
    }
}