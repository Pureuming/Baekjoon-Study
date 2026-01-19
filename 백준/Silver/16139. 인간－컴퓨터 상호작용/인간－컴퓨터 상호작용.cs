using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string str = sr.ReadLine();
        int q = int.Parse(sr.ReadLine());
        
        int[,] prefixSum = new int[26, str.Length];

        for (int i = 0; i < 26; i++)
        {
            prefixSum[i, 0] = 0;
        }
        prefixSum[str[0] - 'a', 0] = 1;
        
        for (int i = 0; i < 26; i++)
        {
            for (int j = 1; j < str.Length; j++)
            {
                if (i == str[j] - 'a')
                    prefixSum[i, j] = prefixSum[i, j - 1] + 1;
                else
                {
                    prefixSum[i, j] = prefixSum[i, j - 1];
                }
            }
        }

        for (int i = 0; i < q; i++)
        {
            string[] input = sr.ReadLine().Split();
            char alpha = char.Parse(input[0]);
            int index = alpha - 'a';
            int l = int.Parse(input[1]);
            int r = int.Parse(input[2]);

            sb.Append(l != 0 ? prefixSum[index, r] - prefixSum[index, l - 1] : prefixSum[index, r]);
            sb.AppendLine();
        }
        
        sw.Write(sb);
    }
}