using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int r1 = int.Parse(input[0]);
        int s = int.Parse(input[1]);
        
        sw.Write(2 * s - r1);
    }
}