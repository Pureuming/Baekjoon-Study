using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int t = int.Parse(sr.ReadLine());

        long[,] c = new long[30, 30];
        for (int i = 0; i < 30; i++)
        {
            c[i, 0] = c[i, i] = 1;
            for (int j = 1; j < i; j++)
            {
                c[i, j] = c[i - 1, j - 1] + c[i - 1, j];
            }
        }

        for (int i = 0; i < t; i++)
        {
            string[] input = sr.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            sb.AppendLine(c[m, n].ToString());
        }
        sw.Write(sb);
    }
}