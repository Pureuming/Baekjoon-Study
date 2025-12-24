using System.IO;

class Backjoon
{
    static int N, Min;
    static int[,] arr;
    static bool[] selected;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        N = int.Parse(sr.ReadLine());
        arr = new int[N, N];
        selected = new bool[N];
        Min = int.MaxValue;

        for (int i = 0; i < N; i++)
        {
            string[] input = sr.ReadLine().Split();
            for (int j = 0; j < N; j++)
            {
                arr[i, j] = int.Parse(input[j]);
            }
        }
        
        DFS(0, 0);
        
        sw.Write(Min);
    }

    static void DFS(int depth, int index)
    {
        if (depth == N / 2)
        {
            int team1 = 0;
            int team2 = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (selected[i] && selected[j])
                        team1 += arr[i, j] + arr[j, i];
                    else if (!selected[i] && !selected[j])
                        team2 += arr[i, j] + arr[j, i];
                }
            }
            
            int score = Math.Abs(team1 - team2);
            if (score < Min) Min = score;
            return;
        }

        for (int i = index; i < N; i++)
        {
            selected[i] = true;
            DFS(depth + 1, i + 1);
            selected[i] = false;
        }
    }
}