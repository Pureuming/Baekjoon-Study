using System.IO;

class Backjoon
{
    static int[,] matrix;
    static int minus, zero, one;
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
        
        sw.WriteLine(minus);
        sw.WriteLine(zero);
        sw.Write(one);
    }

    static void Divide(int x, int y, int size)
    {
        bool isOneNum = true;
        for (int i = x; i < x + size && isOneNum; i++)
        {
            for (int j = y; j < y + size; j++)
            {
                if (matrix[x, y] != matrix[i, j])
                {
                    isOneNum = false;
                    break;
                }
            }
        }

        if (isOneNum)
        {
            switch (matrix[x, y])
            {
                case -1:
                    minus++;
                    break;
                case 0:
                    zero++;
                    break;
                case 1:
                    one++;
                    break;
            }
            return;
        }

        Divide(x, y, size/3);
        Divide(x, y + size/3, size/3);
        Divide(x, y + size/3 * 2, size/3);
        
        Divide(x + size/3, y, size/3);
        Divide(x + size/3, y + size/3, size/3);
        Divide(x + size/3, y + size/3 * 2, size/3);
        
        Divide(x + size/3 * 2, y, size/3);
        Divide(x + size/3 * 2, y + size/3, size/3);
        Divide(x + size/3 * 2, y + size/3 * 2, size/3);
    }
}