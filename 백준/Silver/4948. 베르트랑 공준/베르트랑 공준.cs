using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            int n = int.Parse(sr.ReadLine());
            int result = 0;

            if (n == 0) break;
            
            for (int i = n + 1; i <= 2 * n; i++)
            {
                if (IsPrime(i))
                {
                    result++;
                }
            }

            sb.AppendLine(result.ToString());
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