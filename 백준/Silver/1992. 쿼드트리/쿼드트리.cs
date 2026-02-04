using System.IO;
using System.Text;

class Backjoon
{
    static int[,] matrix;
    static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());

        matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = input[j] == '1' ? 1 : 0;
            }
        }

        Divide(0, 0, n);
        
        sw.Write(sb);
    }

    static void Divide(int x, int y, int size)
    {
        bool isOneColor = true;
        for (int i = x; i < x + size; i++)
        {
            for (int j = y; j < y + size; j++)
            {
                if (matrix[x, y] != matrix[i, j])
                {
                    isOneColor = false;
                    break;
                }
            }

            if (!isOneColor) break;
        }

        if (isOneColor)
        {
            if (matrix[x, y] == 0)
                sb.Append(0);
            else
                sb.Append(1);
            return;
        }

        sb.Append('(');
        Divide(x, y, size/2);
        Divide(x, y + size/2, size/2);
        Divide(x + size/2, y, size/2);
        Divide(x + size/2, y + size/2, size/2);
        sb.Append(')');
    }
}