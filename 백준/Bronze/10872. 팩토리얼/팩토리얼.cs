using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        
        sw.Write(Factorial(n));
    }

    static int Factorial(int n)
    {
        return n == 0 ? 1 : n * Factorial(n - 1);
    }
}