using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int distance = int.Parse(sr.ReadLine());
        int result = 0;
        
        while (distance > 5)
        {
            distance -= 5;
            result++;
        }
        
        sw.Write(result + 1);
    }
}