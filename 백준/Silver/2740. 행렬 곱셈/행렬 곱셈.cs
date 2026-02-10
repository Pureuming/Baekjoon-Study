using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string[] inputA = sr.ReadLine().Split();
        int n = int.Parse(inputA[0]);
        int m = int.Parse(inputA[1]);
        int[,] matrixA = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] numA = sr.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                matrixA[i, j] = int.Parse(numA[j]);
            }
        }
        
        string[] inputB = sr.ReadLine().Split();
        int k = int.Parse(inputB[1]);
        int[,] matrixB = new int[m, k];
        for (int i = 0; i < m; i++)
        {
            string[] numB = sr.ReadLine().Split();
            for (int j = 0; j < k; j++)
            {
                matrixB[i, j] = int.Parse(numB[j]);
            }
        }

        int[,] matrix = new int[n, k];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                int sum = 0;
                for (int l = 0; l < m; l++)
                {
                    sum += matrixA[i, l] * matrixB[l, j];
                }
                matrix[i, j] = sum;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                sb.Append(matrix[i, j]).Append(' ');
            }
            sb.AppendLine();
        }
        
        sw.Write(sb);
    }
}