using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] data = sr.ReadLine().Split();
        int n = int.Parse(data[0]);
        int k = int.Parse(data[1]);

        int[,] dp = new int[n + 1, k + 1];
        (int w, int v)[] items = new (int, int)[n + 1];

        for (int i = 1; i <= n; i++)
        {
            string[] input = sr.ReadLine().Split();
            items[i] = (int.Parse(input[0]), int.Parse(input[1]));
        }
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j <= k; j++)
            {
                if (j < items[i].w)
                {
                    dp[i, j] = dp[i - 1, j];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - items[i].w] + items[i].v);
                }
            }
        }
        
        sw.Write(dp[n, k]);
    }
}