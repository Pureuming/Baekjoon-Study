using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        
        string[] input = sr.ReadLine().Split();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                sb.AppendLine(i.ToString());
            }
        }
        sw.Write(sb.ToString());
    }

    static bool IsPrime(int num)
    {
        if (num == 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        
        int limit = (int)Math.Sqrt(num);

        for (int i = 3; i <= limit; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}