using System.IO;
using System.Text;

class Backjoon
{
    static long[] heights;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]);
            if (n == 0) break;

            heights = new long[n + 1];
            for (int i = 1; i <= n; i++)
            {
                heights[i] = int.Parse(input[i]);
            }

            long result = Divide(1, n);
            sb.AppendLine(result.ToString());
        }
        
        sw.Write(sb);
    }

    static long Divide(int left, int right)
    {
        if (left == right) return heights[left];
        
        int mid = (left + right) / 2;

        long result = Math.Max(Divide(left, mid), Divide(mid + 1, right));

        int low = mid;
        int high = mid + 1;
        long height = Math.Min(heights[low], heights[high]);
        result = Math.Max(result, height * 2);

        while (left < low || high < right)
        {
            if (high < right && (low <= left || heights[low - 1] < heights[high + 1]))
            {
                high++;
                height = Math.Min(height, heights[high]);
            }
            else
            {
                low--;
                height = Math.Min(height, heights[low]);
            }
            result = Math.Max(result, height * (high - low + 1));
        }
        return result;
    }
}