using System.IO;
using System.Text;

class Backjoon
{
    private static int N, M;
    private static int[] result;
    private static StringBuilder sb = new StringBuilder();
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        
        result = new int[M];
        
        DFS(0, 1);

        sw.Write(sb);
    }

    static void DFS(int depth, int prev)
    {
        if (depth == M)
        {
            for (int i = 0; i < M; i++)
            {
                sb.Append(result[i]).Append(" ");
            }
            sb.AppendLine();
            return;
        }

        for (int i = prev; i <= N; i++)
        {
            result[depth] = i;
            
            DFS(depth + 1, i);
        }
    }
}