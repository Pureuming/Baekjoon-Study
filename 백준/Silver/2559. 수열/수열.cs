using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] count = sr.ReadLine().Split();
        int n = int.Parse(count[0]);
        int k = int.Parse(count[1]);
        
        int[] degrees = new int[n + 1];
        int[] prefixSum = new int[n + 1];

        string[] input = sr.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            degrees[i] = int.Parse(input[i - 1]);
            prefixSum[i] = prefixSum[i - 1] + degrees[i];
        }

        int result = int.MinValue;
        for (int i = k; i <= n; i++)
        {
            result = Math.Max(result, prefixSum[i] - prefixSum[i - k]);
        }
        
        sw.Write(result);
    }
}