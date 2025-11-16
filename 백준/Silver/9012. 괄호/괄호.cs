using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int t = int.Parse(sr.ReadLine());
        
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < t; i++)
        {
            stack.Clear();
            string input = sr.ReadLine();
            bool needCheck = true;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    stack.Push(c);
                    continue;
                }
                
                if (stack.Count == 0)
                {
                    needCheck = false;
                    break;
                }
                    
                stack.Pop();
            }

            sb.AppendLine(needCheck && stack.Count == 0 ? "YES" : "NO");
        }
        sw.Write(sb.ToString());
    }
}