using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] input = Console.ReadLine().Split();
        int row = int.Parse(input[0]);
        int col = int.Parse(input[1]);

        int[,] matrix1 = new int[row, col];
        int[,] matrix2 = new int[row, col];
        int[,] result = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            string[] line = Console.ReadLine().Split();
            for (int j = 0; j < col; j++)
            {
                int num = int.Parse(line[j]);
                matrix1[i, j] = num;
            }
        }

        for (int i = 0; i < row; i++)
        {
            string[] line = Console.ReadLine().Split();
            for (int j = 0; j < col; j++)
            {
                int num = int.Parse(line[j]);
                matrix2[i, j] = num;
            }
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
                sb.Append(result[i, j] + " ");
            }
            sb.AppendLine();
        }
        Console.Write(sb.ToString().TrimEnd());
    }
}