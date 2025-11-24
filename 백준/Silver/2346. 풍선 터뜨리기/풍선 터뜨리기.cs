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
        
        LinkedList<(int index, int num)> list = new LinkedList<(int, int)>();
        
        string[] input = sr.ReadLine().Split();

        for (int i = 0; i < n; i++)
        {
            list.AddLast((i + 1, int.Parse(input[i])));
        }

        LinkedListNode<(int index, int num)> current = list.First;

        while (true)
        {
            int index = current.Value.index;
            int num = current.Value.num;
            sb.Append(index).Append(" ");
            
            LinkedListNode<(int index, int num)> nextNode = current.Next ?? list.First;
            list.Remove(current);

            if (list.Count == 0) break;
            
            if (num > 0)
            {
                for (int i = 1; i < num; i++)
                {
                    nextNode = nextNode.Next ?? list.First;
                }
            }
            else
            {
                for (int i = 0; i < Math.Abs(num); i++)
                {
                    nextNode = nextNode.Previous ?? list.Last;
                }
            }
            
            current = nextNode;
        }

        sw.Write(sb.ToString());
    }
}