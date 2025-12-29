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
            
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            if (a == 0 && b == 0) break;
            
            sb.AppendLine(a > b ? "Yes" : "No");
        }
        sw.Write(sb);
    }
}