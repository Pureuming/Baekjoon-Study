using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);

        long gcd = a > b ? GCD(a, b) : GCD(b, a);
        
        sw.Write(a * b / gcd);
    }

    static long GCD(long a, long b)
    {
        if (b == 0)
            return a;
    
        return GCD(b, a % b);
    }
}