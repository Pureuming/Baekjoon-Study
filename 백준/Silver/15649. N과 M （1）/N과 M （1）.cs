using System.IO;
using System.Text;

class Backjoon
{
    private static int N, M;
    private static int[] result;
    private static bool[] visited;
    private static StringBuilder sb = new StringBuilder();
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        
        result = new int[M];
        visited = new bool[N + 1];
        
        DFS(0);

        sw.Write(sb);
    }

    static void DFS(int depth)
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

        for (int i = 1; i <= N; i++)
        {
            if (visited[i]) continue;

            visited[i] = true;
            result[depth] = i;

            DFS(depth + 1);

            visited[i] = false;
        }
    }
}