using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[,] prefixSum = new int[n + 1, n + 1];

        for (int i = 1; i <= n; i++)
        {
            string[] nums = sr.ReadLine().Split();
            for (int j = 1; j <= n; j++)
            {
                int num = int.Parse(nums[j - 1]);
                prefixSum[i, j] =
                    prefixSum[i - 1, j] +
                    prefixSum[i, j - 1] -
                    prefixSum[i - 1, j - 1] +
                    num;
            }
        }

        for (int i = 0; i < m; i++)
        {
            string[] coors = sr.ReadLine().Split();
            int x1 = int.Parse(coors[0]);
            int y1 = int.Parse(coors[1]);
            int x2 = int.Parse(coors[2]);
            int y2 = int.Parse(coors[3]);

            int result =
                    prefixSum[x2, y2] -
                    prefixSum[x1 - 1, y2] -
                    prefixSum[x2, y1 - 1] +
                    prefixSum[x1 - 1 , y1 - 1];

            sb.AppendLine(result.ToString());
        }
        
        sw.Write(sb);
    }
}