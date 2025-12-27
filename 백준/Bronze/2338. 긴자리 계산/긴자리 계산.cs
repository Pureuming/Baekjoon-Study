using System.IO;
using System.Numerics;
using System.Text;

class Backjoon
{    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        BigInteger a = BigInteger.Parse(sr.ReadLine());
        BigInteger b = BigInteger.Parse(sr.ReadLine());

        sb.Append(a + b).AppendLine();
        sb.Append(a - b).AppendLine();
        sb.Append(a * b);
        
        sw.Write(sb);
    }
}