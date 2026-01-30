using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());

        (int start, int end)[] times = new (int, int)[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            times[i] = (int.Parse(input[0]), int.Parse(input[1]));
        }

        times = times.OrderBy(x => x.end).ThenBy(x => x.start).ToArray();

        int result = 0;
        int selected = 0;
        for (int i = 0; i < n; i++)
        {
            if (times[i].start >= selected)
            {
                result++;
                selected = times[i].end;
            }
        }
        
        sw.Write(result);
    }
}