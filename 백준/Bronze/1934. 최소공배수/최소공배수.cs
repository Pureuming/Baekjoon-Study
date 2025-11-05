using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int count = int.Parse(sr.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] input = sr.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            
            int gcd = a > b ? GCD(a, b) : GCD(b, a);

            sb.AppendLine((a * b / gcd).ToString());
        }
        sw.Write(sb.ToString());
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }

        return a;
    }
}