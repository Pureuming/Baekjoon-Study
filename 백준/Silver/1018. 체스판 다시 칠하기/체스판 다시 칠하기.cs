class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        char[,] board = new char[n, m];
        int min = int.MaxValue;
            
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < m; j++)
            {
                board[i, j] = line[j];
            }
        }

        for (int y = 0; y <= n - 8; y++)
        {
            for (int x = 0; x <= m - 8; x++)
            {
                int wCount = 0;
                int bCount = 0;
                for (int row = y; row < y + 8; row++)
                {
                    for (int col = x; col < x + 8; col++)
                    {
                        switch ((row + col) % 2)
                        {
                            case 0:
                                if (board[row, col] != 'W') wCount++;
                                if (board[row, col] != 'B') bCount++;
                                break;
                            case 1:
                                if (board[row, col] != 'B') wCount++;
                                if (board[row, col] != 'W') bCount++;
                                break;
                        }
                    }
                }
                int count = Math.Min(wCount, bCount);
                if (count < min) min = count;
            }
        }
        Console.Write(min);
    }
}