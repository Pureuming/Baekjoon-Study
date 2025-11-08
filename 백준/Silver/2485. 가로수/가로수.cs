using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(sr.ReadLine());
        }

        int gcd = arr[1] - arr[0];
        for (int i = 2; i < n; i++)
        {
            int gap = arr[i] - arr[i - 1];
            gcd = gap > gcd ? GCD(gap, gcd) : GCD(gcd, gap);
        }

        int result = 0;
        for (int i = 1; i < n; i++)
        {
            int gap = arr[i] - arr[i - 1];
            result += gap / gcd - 1;
        }

        sw.Write(result);
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
    
        return GCD(b, a % b);
    }
}