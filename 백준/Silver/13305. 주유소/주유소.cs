using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());

        long[] roads = sr.ReadLine().Split().Select(long.Parse).ToArray();
        long[] prices = sr.ReadLine().Split().Select(long.Parse).ToArray();

        long minPrice = prices[0];
        long result = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            
            result += minPrice * roads[i];
        }
        
        sw.Write(result);
    }
}