using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        string[] input = sr.ReadLine().Split();
        long n = long.Parse(input[0]);
        long m = long.Parse(input[1]);
        
        sw.Write(Math.Abs(n - m));
    }
}