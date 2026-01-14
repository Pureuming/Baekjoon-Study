using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string first = sr.ReadLine();
        string second = sr.ReadLine();

        int[,] dp = new int[first.Length + 1, second.Length + 1];

        for (int i = 1; i <= first.Length; i++)
        {
            for (int j = 1; j <= second.Length; j++)
            {
                if (first[i - 1] == second[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        int result = 0;
        for (int i = 0; i <= first.Length; i++)
        {
            for (int j = 0; j <= second.Length; j++)
            {
                result = Math.Max(result, dp[i, j]);
            }
        }
        
        sw.Write(result);
    }
}