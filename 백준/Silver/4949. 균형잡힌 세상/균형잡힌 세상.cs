using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        
        Stack<char> stack = new Stack<char>();

        while (true)
        {
            string input = sr.ReadLine();
            bool needCheck = true;
            stack.Clear();

            if (input == ".") break;

            foreach (char c in input)
            {
                if (c == '(' || c == '[')
                {
                    stack.Push(c);
                    continue;
                }

                if (c == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(')
                    {
                        needCheck = false;
                        break;
                    }
                    
                    stack.Pop();
                    continue;
                }
                
                if (c == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[')
                    {
                        needCheck = false;
                        break;
                    }
                    
                    stack.Pop();
                }
            }

            sb.AppendLine(needCheck && stack.Count == 0 ? "yes" : "no");
        }
        sw.Write(sb.ToString());
    }
}