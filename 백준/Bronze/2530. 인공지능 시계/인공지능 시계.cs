using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int h = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int s = int.Parse(input[2]);
        int d = int.Parse(sr.ReadLine());

        int total = h * 3600 + m * 60 + s + d;

        h = (total / 3600) % 24;
        m = (total / 60) % 60;
        s = total % 60;
        
        sw.Write($"{h} {m} {s}");
    }
}