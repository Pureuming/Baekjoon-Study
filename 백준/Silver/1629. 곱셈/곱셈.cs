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
        long c = long.Parse(input[2]);
        
        sw.Write(Power(a, b, c));
    }

    static long Power(long a, long b, long c)
    {
        long result = 0;
        
        if (b == 0 || b == 1)
        {
            return b == 0 ? 1 : a % c;
        }

        if (b % 2 == 0)
        {
            long temp = Power(a, b / 2, c);
            result = (temp * temp) % c;
        }
        else if (b % 2 == 1)
        {
            long temp = Power(a, b / 2, c);
            result = ((temp * temp) % c * a) % c;
        }
        
        return result;
    }
}