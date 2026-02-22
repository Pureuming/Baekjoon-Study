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
            string[] input = sr.ReadLine().Split();
            int m = int.Parse(input[0]);
            int f = int.Parse(input[1]);

            if (m == 0 && f == 0) break;

            sb.AppendLine((m + f).ToString());
        }
        
        sw.Write(sb);
    }
}