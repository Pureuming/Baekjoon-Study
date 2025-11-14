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
        
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine();

            switch (input[0])
            {
                case '1':
                    int num = int.Parse(input.Substring(2));
                    stack.Push(num);
                    break;
                case '2':
                    sb.AppendLine(stack.Count > 0 ? stack.Pop().ToString() : "-1");
                    break;
                case '3':
                    sb.AppendLine(stack.Count.ToString());
                    break;
                case '4':
                    sb.AppendLine(stack.Count == 0 ? "1" : "0");
                    break;
                case '5':
                    sb.AppendLine(stack.Count > 0 ? stack.Peek().ToString() : "-1");
                    break;
            }
        }
        sw.Write(sb.ToString());
    }
}