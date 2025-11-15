using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int k = int.Parse(sr.ReadLine());
        
        Stack<int> stack = new Stack<int>();
        int result = 0;

        for (int i = 0; i < k; i++)
        {
            int input = int.Parse(sr.ReadLine());

            if (input == 0)
                result -= stack.Pop();
            else
            {
                stack.Push(input);
                result += input;
            }
        }
        sw.Write(result);
    }
}