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

        for (int i = 1; i <= n; i++)
        {
            sb.AppendLine(i.ToString());
        }
        sw.Write(sb);
    }
}