using System.IO;

class Backjoon
{
    static long MOD = 1000000007;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        long n = long.Parse(sr.ReadLine());
        long[,] matrix = { { 1, 1 }, { 1, 0 } };

        long[,] result = Power(matrix, n);
        
        sw.Write(result[0, 1]);
    }

    static long[,] Power(long[,] m, long exp)
    {
        if (exp == 1) return m;

        long[,] temp = Power(m, exp / 2);

        temp = Multiply(temp, temp);

        if (exp % 2 == 1)
        {
            temp = Multiply(temp, m);
        }
        
        return temp;
    }
    
    static long[,] Multiply(long[,] matrixA, long[,] matrixB)
    {
        long[,] temp = new long[2, 2];
    
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    temp[i, j] += matrixA[i, k] * matrixB[k, j];
                    temp[i, j] %= MOD;
                }
            }
        }
        return temp;
    }
}