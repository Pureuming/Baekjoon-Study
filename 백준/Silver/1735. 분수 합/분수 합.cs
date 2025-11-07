using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] frac1 = sr.ReadLine().Split();
        int num1 = int.Parse(frac1[0]);
        int den1 = int.Parse(frac1[1]);
        
        string[] frac2 = sr.ReadLine().Split();
        int num2 = int.Parse(frac2[0]);
        int den2 = int.Parse(frac2[1]);

        int num = num1 * den2 + num2 * den1;
        int den = den1 * den2;

        int gcd = num > den ? GCD(num, den) : GCD(den, num);
        num /= gcd;
        den /= gcd;
        
        sw.Write($"{num} {den}");
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
    
        return GCD(b, a % b);
    }
}