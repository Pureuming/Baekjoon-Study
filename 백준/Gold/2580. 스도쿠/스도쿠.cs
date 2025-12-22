using System.IO;
using System.Text;

class Backjoon
{
    static int[,] sudoku = new int[9, 9];
    static List<(int r, int c)> empty = new List<(int, int)>();
    static bool solved = false;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        for (int r = 0; r < 9; r++)
        {
            string[] input = sr.ReadLine().Split();

            for (int c = 0; c < 9; c++)
            {
                sudoku[r, c] = int.Parse(input[c]);
                if (sudoku[r, c] == 0)
                    empty.Add((r, c));
            }
        }
        
        DFS(0);

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                sb.Append(sudoku[r, c]).Append(' ');
            }
            sb.AppendLine();
        }

        sw.Write(sb.ToString());
    }

    static void DFS(int depth)
    {        
        if (depth == empty.Count)
        {
            solved = true;
            return;
        }
        
        (int r, int c) = empty[depth];

        for (int num = 1; num <= 9; num++)
        {
            if (IsValid(r, c, num))
            {
                sudoku[r, c] = num;
                DFS(depth + 1);
                if (solved) return;
                sudoku[r, c] = 0;
            }
        }
    }

    static bool IsValid(int r, int c, int num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (sudoku[r, i] == num) return false;
        }

        for (int i = 0; i < 9; i++)
        {
            if (sudoku[i, c] == num) return false;
        }

        int row = (r / 3) * 3;
        int col = (c / 3) * 3;

        for (int i = row; i < row + 3; i++)
        {
            for (int j = col; j < col + 3; j++)
            {
                if (sudoku[i, j] == num) return false;
            }   
        }

        return true;
    }
}