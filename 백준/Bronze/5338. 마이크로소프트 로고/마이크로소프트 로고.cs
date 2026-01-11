using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("       _.-;;-._");
        sb.AppendLine("'-..-'|   ||   |");
        sb.AppendLine("'-..-'|_.-;;-._|");
        sb.AppendLine("'-..-'|   ||   |");
        sb.AppendLine("'-..-'|_.-''-._|");

        sw.Write(sb);
    }
}