using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long input = long.Parse(sr.ReadLine());

            if (input <= 2)
            {
                sb.AppendLine("2");
                continue;
            }

            while (true)
            {
                if (IsPrime(input))
                {
                    sb.AppendLine(input.ToString());
                    break;
                }
                input++;
            }
        }
        sw.Write(sb.ToString());
    }

    static bool IsPrime(long num)
    {
        if (num % 2 == 0) return false;
        
        long limit = (long)Math.Sqrt(num);

        for (int i = 3; i <= limit; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}