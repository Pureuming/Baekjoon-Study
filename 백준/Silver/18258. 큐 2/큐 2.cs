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
        Queue<int> queue = new Queue<int>();
        int num = 0;

        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            string command = input[0];

            switch (command)
            {
                case "push":
                    num = int.Parse(input[1]);
                    queue.Enqueue(num);
                    break;
                case "pop":
                    sb.AppendLine(queue.Count > 0 ? queue.Dequeue().ToString() : "-1");
                    break;
                case "size":
                    sb.AppendLine(queue.Count.ToString());
                    break;
                case "empty":
                    sb.AppendLine(queue.Count > 0 ? "0" : "1");
                    break;
                case "front":
                    sb.AppendLine(queue.Count > 0 ? queue.Peek().ToString() : "-1");
                    break;
                case "back":
                    sb.AppendLine(queue.Count > 0 ? num.ToString() : "-1");
                    break;
            }
        }
        sw.Write(sb.ToString());
    }
}