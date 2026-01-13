using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());

        int[] dp = new int[n + 1];
        (int a, int b)[] arr = new (int, int)[n + 1];

        for (int i = 1; i <= n; i++)
        {
            string[] input = sr.ReadLine().Split();
            arr[i] = (int.Parse(input[0]), int.Parse(input[1]));
            dp[i] = 1;
        }

        (int a, int b)[] sortedArr = arr.OrderBy(x => x.a).ToArray();

        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                if (sortedArr[i].b > sortedArr[j].b)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            result = Math.Max(result, dp[i]);
        }
        
        sw.Write(n - result);
    }
}