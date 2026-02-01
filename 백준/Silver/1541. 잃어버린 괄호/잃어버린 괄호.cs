using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split('-');
        int result = 0;

        result += SplitAndSum(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            result -= SplitAndSum(input[i]);
        }
        
        sw.Write(result);
    }

    static int SplitAndSum(string section)
    {
        string[] split = section.Split('+');
        int sum = 0;

        foreach (string s in split)
        {
            sum += int.Parse(s);
        }

        return sum;
    }
}