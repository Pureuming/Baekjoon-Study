using System.IO;
using System.Text;
using System.Linq;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());
        int[] a = sr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = sr.ReadLine().Split().Select(int.Parse).ToArray();
        int m = int.Parse(sr.ReadLine());
        int[] c = sr.ReadLine().Split().Select(int.Parse).ToArray();
        
        LinkedList<int> list = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            if (a[i] == 0)
                list.AddLast(b[i]);
        }

        for (int i = 0; i < m; i++)
        {
            list.AddFirst(c[i]);
        }

        for (int i = 0; i < m; i++)
        {
            int result = list.Last.Value;
            list.RemoveLast();
            sb.Append(result).Append(" ");
        }
        sw.Write(sb.ToString());
    }
}