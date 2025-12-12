using System.IO;
using System.Text;

class Backjoon
{
    static StringBuilder moves = new StringBuilder();
    static int count = 0;
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());

        Hanoi(n, 1, 3, 2);
        sb.AppendLine(count.ToString()).Append(moves);
        
        sw.Write(sb);
    }

    static void Hanoi(int n, int from, int to, int sub)
    {
        if (n == 1)
        {
            moves.Append(from).Append(" ").Append(to).AppendLine();
            count++;
            return;
        }
        Hanoi(n - 1, from, sub, to);
        moves.Append(from).Append(" ").Append(to).AppendLine();
        count++;
        Hanoi(n - 1,sub, to, from);
    }
}