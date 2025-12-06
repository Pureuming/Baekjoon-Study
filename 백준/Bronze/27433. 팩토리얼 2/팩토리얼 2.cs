using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        long n = long.Parse(sr.ReadLine());
        
        sw.Write(Factorial(n));
    }

    static long Factorial(long n)
    {
        return n == 0 ? 1 : n * Factorial(n - 1);
    }
}