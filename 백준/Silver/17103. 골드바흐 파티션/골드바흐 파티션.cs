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
        HashSet<int> primeHash = new HashSet<int>();

        for (int i = 2; i < 1000000; i++)
        {
            if (IsPrime(i))
            {
                primeHash.Add(i);
            }
        }

        for (int i = 0; i < t; i++)
        {
            int input = int.Parse(sr.ReadLine());

            int result = 0;
            for (int j = 2; j <= input / 2; j++)
            {
                if (primeHash.Contains(j) && primeHash.Contains(input - j))
                    result++;
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