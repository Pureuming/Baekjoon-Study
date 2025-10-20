using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        string input = sr.ReadLine();
        int[] arr = new int[input.Length];
        int[] count = new int[10];

        for (int i = 0; i < input.Length; i++)
        {
            count[input[i] - '0']++;
        }

        int index = 0;
        for (int i = 9; i >= 0; i--)
        {
            while (count[i] > 0)
            {
                arr[index++] = i;
                count[i]--;
            }
        }

        foreach (var t in arr)
        {
            sw.Write(t);
        }
    }
}