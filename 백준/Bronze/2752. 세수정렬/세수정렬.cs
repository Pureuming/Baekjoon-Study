using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] arr = sr.ReadLine().Split().Select(int.Parse).ToArray();
        
        Array.Sort(arr);

        foreach (int n in arr)
        {
            sw.Write(n);
            sw.Write(' ');
        }
    }
}