using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[] remainders = new int[m];

        string[] nums = sr.ReadLine().Split();
        long prefixSum = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(nums[i - 1]);
            prefixSum += num;
            remainders[prefixSum % m]++;
        }

        long result = remainders[0];
        for (int i = 0; i < m; i++)
        {
            result += (long)remainders[i] * (remainders[i] - 1) / 2;
        }
        
        sw.Write(result);
    }
}