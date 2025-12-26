using System.IO;
using System.Text;

class Backjoon
{
    static int[,,] DP = new int[21, 21, 21];
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string[] input = sr.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if (a == -1 && b == -1 && c == -1) break;

            int result = W(a, b, c);
            sb.AppendLine($"w({a}, {b}, {c}) = {result}");
        }
        
        sw.Write(sb);
    }

    static int W(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0) return 1;
        if (a > 20 || b > 20 || c > 20) return W(20, 20, 20);
        if (DP[a, b, c] != 0) return DP[a, b, c];

        if (a < b && b < c)
        {
            DP[a, b, c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
            return DP[a, b, c];
        }
        
        DP[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
        return DP[a, b, c];
    }
}