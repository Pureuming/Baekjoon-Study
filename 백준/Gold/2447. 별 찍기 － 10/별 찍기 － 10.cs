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
        char[,] matrix = new char[n, n];
        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < n; x++)
            {
                matrix[y, x] = ' ';
            }
        }

        Star(matrix, 0, 0, n);

        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < n; x++)
            {
                sb.Append(matrix[y, x]);
            }
            sb.AppendLine();
        }
        
        sw.Write(sb);
    }

    static void Star(char[,] matrix, int x, int y, int length)
    {
        if (length == 1)
        {
            matrix[y, x] = '*';
            return;
        }
        
        int newLength = length / 3;

        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 1 && j == 1) continue;
                Star(matrix, x + newLength * i, y + newLength * j, newLength);
            }
        }
    }
}