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
        int k = int.Parse(input[1]);
        Queue<int> queue = new Queue<int>();

        for (int i = 1; i <= n; i++)
        {
            queue.Enqueue(i);
        }

        sb.Append("<");
        while (true)
        {
            for (int i = 0; i < k - 1; i++)
            {
                int num = queue.Dequeue();
                queue.Enqueue(num);
            }

            sb.Append(queue.Dequeue());
            
            if (queue.Count == 0) break;

            sb.Append(", ");
        }
        sb.Append(">");

        sw.Write(sb.ToString());
    }
}