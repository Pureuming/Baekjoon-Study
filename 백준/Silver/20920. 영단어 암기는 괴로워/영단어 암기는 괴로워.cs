using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string[] nm = sr.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine();

            if (input.Length < m) continue;

            if (!dict.TryAdd(input, 1))
                dict[input]++;
        }
        
        List<string> list = dict.Keys.ToList();
        
        list.Sort((a, b) =>
        {
            if (dict[a].CompareTo(dict[b]) > 0)
                return -1;
            else if (dict[a].CompareTo(dict[b]) < 0)
                return 1;
            
            if (a.Length.CompareTo(b.Length) > 0)
                return -1;
            else if (a.Length.CompareTo(b.Length) < 0)
                return 1;
            
            return a.CompareTo(b);
        });

        foreach (string str in list)
        {
            sb.AppendLine(str);
        }
        
        sw.Write(sb);
    }
}