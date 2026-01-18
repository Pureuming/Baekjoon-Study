using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int a = int.Parse(sr.ReadLine());
        int b = int.Parse(sr.ReadLine());
        
        sw.Write(a + b);
    }
}