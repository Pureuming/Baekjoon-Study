using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        Dictionary<int, string> nameDict = new Dictionary<int, string>();
        Dictionary<string, int> numDict = new Dictionary<string, int>();

        for (int i = 1; i <= n; i++)
        {
            string name = sr.ReadLine();
            nameDict.Add(i, name);
            numDict.Add(name, i);
        }

        for (int i = 0; i < m; i++)
        {
            string quiz = sr.ReadLine();

            if (int.TryParse(quiz, out int num))
                sb.AppendLine(nameDict[num]);
            else
                sb.AppendLine(numDict[quiz].ToString());
        }
        sw.Write(sb.ToString());
    }
}