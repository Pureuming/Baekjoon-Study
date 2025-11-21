using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        Queue<int> queue = new Queue<int>();
        int num = 0;

        for (int i = 1; i <= n; i++)
        {
            queue.Enqueue(i);
        }

        while (queue.Count != 1)
        {
            queue.Dequeue();
            num = queue.Dequeue();
            queue.Enqueue(num);
        }
        
        sw.Write(queue.Dequeue());
    }
}