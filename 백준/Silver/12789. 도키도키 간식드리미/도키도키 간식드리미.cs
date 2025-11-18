using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        string[] input = sr.ReadLine().Split();
        Queue<int> queue = new Queue<int>();
        Stack<int> stack = new Stack<int>();
        int num = 1;

        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(int.Parse(input[i]));
        }

        while (queue.Count > 0 || stack.Count > 0)
        {
            if (queue.Count > 0 && queue.Peek() == num)
            {
                queue.Dequeue();
                num++;
            }
            else if (stack.Count > 0 && stack.Peek() == num)
            {
                stack.Pop();
                num++;
            }
            else if (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            else
            {
                sw.Write("Sad");
                return;
            }
        }
        sw.Write("Nice");
    }
}