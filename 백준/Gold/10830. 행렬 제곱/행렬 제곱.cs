using System.IO;
using System.Text;

class Backjoon
{
    static int[,] matrix;
    static int n;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string[] inputA = sr.ReadLine().Split();
        n = int.Parse(inputA[0]);
        long b = long.Parse(inputA[1]);
        matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(input[j]) % 1000;
            }
        }

        int[,] result = Power(matrix, b, 1000);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sb.Append(result[i, j]).Append(' ');
            }
            sb.AppendLine();
        }
        
        sw.Write(sb);
    }

    static int[,] Multiply(int[,] matrixA, int[,] matrixB, int mod)
    {
        int[,] temp = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                temp[i, j] = sum % mod;
            }
        }
        return temp;
    }

    static int[,] Power(int[,] baseMatrix, long b, int mod)
    {
        if (b == 1)
            return baseMatrix;

        int[,] temp = Power(baseMatrix, b / 2, mod);

        if (b % 2 == 0)
        {
            return Multiply(temp, temp, mod);
        }
        else
        {
            return Multiply(Multiply(temp, temp, mod), baseMatrix, mod);
        }
    }
}