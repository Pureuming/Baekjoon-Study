using System.IO;

class Backjoon
{
    static int[,] matrix;
    static int white, blue;
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());

        matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        
        Divide(0, 0, n);
        
        sw.WriteLine(white);
        sw.Write(blue);
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
                white++;
            else
                blue++;
            return;
        }

        Divide(x, y, size/2);
        Divide(x + size/2, y, size/2);
        Divide(x, y + size/2, size/2);
        Divide(x + size/2, y + size/2, size/2);
    }
}