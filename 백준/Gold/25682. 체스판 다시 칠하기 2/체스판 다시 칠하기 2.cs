using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int k = int.Parse(input[2]);

        int[,] diffWhite = new int[n + 1, m + 1];
        int[,] prefixSumWhite = new int[n + 1, m + 1];

        for (int i = 1; i <= n; i++)
        {
            string line = sr.ReadLine();
            for (int j = 1; j <= m; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    diffWhite[i, j] = line[j - 1] == 'W' ? 0 : 1;
                }
                else
                {
                    diffWhite[i, j] = line[j - 1] == 'B' ? 0 : 1;
                }
                
                prefixSumWhite[i, j] = prefixSumWhite[i - 1, j]
                                       + prefixSumWhite[i, j - 1]
                                       - prefixSumWhite[i - 1, j - 1]
                                       + diffWhite[i, j];
            }
        }

        int area = k * k;
        int result = int.MaxValue;
        for (int i = 1; i <= n - k + 1; i++)
        {
            for (int j = 1; j <= m - k + 1; j++)
            {
                int white = prefixSumWhite[i + k - 1, j + k - 1]
                            - prefixSumWhite[i - 1, j + k - 1]
                            - prefixSumWhite[i + k - 1, j - 1]
                            + prefixSumWhite[i - 1, j - 1];

                int black = area - white;
                
                result = Math.Min(result, Math.Min(white, black));
            }
        }
        
        sw.Write(result);
    }
}