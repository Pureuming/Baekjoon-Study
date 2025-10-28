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
        HashSet<int> cards = new HashSet<int>(Array.ConvertAll(sr.ReadLine().Split(), int.Parse));
        
        int m = int.Parse(sr.ReadLine());
        int[] numM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        foreach (var num in numM)
            sb.Append(cards.Contains(num) ? "1 " : "0 ");
        
        sw.Write(sb.ToString().TrimEnd());
    }
}