using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string[] count = sr.ReadLine().Split();
        int n = int.Parse(count[0]);
        int m = int.Parse(count[1]);
        
        string[] num = sr.ReadLine().Split();
        int[] numbers = new int[n + 1];
        int[] prefixSum = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            numbers[i] = int.Parse(num[i - 1]);
            prefixSum[i] = prefixSum[i - 1] + numbers[i];
        }

        for (int i = 0; i < m; i++)
        {
            string[] input = sr.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int result = prefixSum[b] - prefixSum[a - 1];

            sb.AppendLine(result.ToString());
        }
        
        sw.Write(sb);
    }
}