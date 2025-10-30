using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int count = int.Parse(sr.ReadLine());
        HashSet<string> people = new HashSet<string>();

        for (int i = 0; i < count; i++)
        {
            string[] input = sr.ReadLine().Split();

            if (input[1] == "enter")
                people.Add(input[0]);
            else if (input[1] == "leave")
                people.Remove(input[0]);
        }

        string[] name = new string[people.Count];
        int index = 0;
        foreach (string str in people)
        {
            name[index++] = str;
        }

        var sort = name.OrderByDescending(x => x);

        foreach (var s in sort)
        {
            sb.AppendLine(s);
        }
        sw.Write(sb.ToString());
    }
}