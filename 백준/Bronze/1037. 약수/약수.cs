using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int count = int.Parse(sr.ReadLine());
        int[] factors = sr.ReadLine().Split().Select(int.Parse).ToArray();

        int min = 1000000;
        int max = 1;

        foreach (var f in factors)
        {
            if (f < min) min = f;
            if (f > max) max = f;
        }
        
        sw.Write(min * max);
    }
}