using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());
        string[] numN = sr.ReadLine().Split();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(numN[i]);
            
            if (!dict.TryAdd(temp, 1))
                dict[temp]++;
        }
        
        int m = int.Parse(sr.ReadLine());
        string[] numM = sr.ReadLine().Split();

        for (int i = 0; i < m; i++)
        {
            int temp = int.Parse(numM[i]);

            if (dict.TryGetValue(temp, out int count))
                sb.Append(count).Append(' ');
            else
                sb.Append('0').Append(' ');
        }
        sw.Write(sb.ToString().TrimEnd());
    }
}