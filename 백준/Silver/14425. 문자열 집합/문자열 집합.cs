using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string[] counts = sr.ReadLine().Split();
        int n = int.Parse(counts[0]);
        int m = int.Parse(counts[1]);
        HashSet<string> s = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            s.Add(sr.ReadLine());
        }

        int result = 0;
        for (int i = 0; i < m; i++)
        {
            if (s.Contains(sr.ReadLine()))
                result++;
        }

        sb.Append(result);
        sw.Write(sb.ToString());
    }
}