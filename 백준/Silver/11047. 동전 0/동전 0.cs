using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        int[] prices = new int[n];

        for (int i = 0; i < n; i++)
        {
            prices[i] = int.Parse(sr.ReadLine());
        }

        int result = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            result += k / prices[i];
            k %= prices[i];

            if (k == 0) break;
        }
        
        sw.Write(result);
    }
}