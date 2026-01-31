using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());

        int[] times = sr.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(times);

        int sum = 0;
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            sum += times[i];
            result += sum;
        }
        
        sw.Write(result);
    }
}