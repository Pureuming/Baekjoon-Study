using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        long n = long.Parse(sr.ReadLine());
        
        sw.Write(n % 2 == 1 ? "SK" : "CY");
    }
}