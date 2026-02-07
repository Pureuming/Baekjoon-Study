using System.IO;
using System.Numerics;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        BigInteger n = BigInteger.Parse(input[0]);
        BigInteger m = BigInteger.Parse(input[1]);
        
        sw.WriteLine(n / m);
        sw.Write(n % m);
    }
}