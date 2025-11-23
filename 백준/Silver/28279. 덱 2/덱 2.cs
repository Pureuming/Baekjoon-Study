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
        LinkedList<int> list = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine();

            switch (input[0])
            {
                case '1':
                    int num1 = int.Parse(input.Substring(2));
                    list.AddFirst(num1);
                    break;
                case '2':
                    int num2 = int.Parse(input.Substring(2));
                    list.AddLast(num2);
                    break;
                case '3':
                    sb.AppendLine(list.Count > 0 ? list.First.Value.ToString() : "-1");
                    if (list.Count > 0)
                        list.RemoveFirst();
                    break;
                case '4':
                    sb.AppendLine(list.Count > 0 ? list.Last.Value.ToString() : "-1");
                    if (list.Count > 0)
                        list.RemoveLast();
                    break;
                case '5':
                    sb.AppendLine(list.Count.ToString());
                    break;
                case '6':
                    sb.AppendLine(list.Count > 0 ? "0" : "1");
                    break;
                case '7':
                    sb.AppendLine(list.Count > 0 ? list.First.Value.ToString() : "-1");
                    break;
                case '8':
                    sb.AppendLine(list.Count > 0 ? list.Last.Value.ToString() : "-1");
                    break;
            }
        }
        sw.Write(sb.ToString());
    }
}