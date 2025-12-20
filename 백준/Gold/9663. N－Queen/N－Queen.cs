using System.IO;

class Backjoon
{
    private static int N, count;
    private static int[] col;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        N = int.Parse(sr.ReadLine());
        
        col = new int[N];
        
        DFS(0);

        sw.Write(count);
    }

    static void DFS(int row)
    {
        if (row == N)
        {
            count++;
            return;
        }

        for (int i = 0; i < N; i++)
        {
            col[row] = i;

            bool isOkay = true;
            for (int j = 0; j < row; j++)
            {
                if (col[row] == col[j])
                {
                    isOkay = false;
                    break;
                }

                if (Math.Abs(row - j) == Math.Abs(col[row] - col[j]))
                {
                    isOkay = false;
                    break;
                }
            }
            
            if (isOkay)
                DFS(row + 1);
        }
    }
}