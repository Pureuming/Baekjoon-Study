using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string input = sr.ReadLine();

        var invert = input.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray();

        sw.Write(new string(invert));
    }
}