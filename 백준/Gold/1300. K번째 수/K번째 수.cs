using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int n = int.Parse(sr.ReadLine());
        long k = long.Parse(sr.ReadLine());
        long low = 1;
        long high = k * k;
        long answer = 0;

        while (low <= high)
        {
            long mid = (low + high) / 2;
            long count = 0;

            for (int i = 1; i <= n; i++)
            {
                count += Math.Min(n, mid / i);
            }

            if (count >= k)
            {
                answer = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        
        sw.Write(answer);
    }
}