using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        string[] numA = sr.ReadLine().Split();
        string[] numB = sr.ReadLine().Split();

        int[] a = new int[n];
        int[] b = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(numA[i]);
            b[i] = int.Parse(numB[i]);
        }

        Array.Sort(a);
        Array.Sort(b);
        Array.Reverse(b);

        int result = 0;
        for (int i = 0; i < n; i++)
        {
            result += a[i] * b[i];
        }

        sw.Write(result);
    }
}