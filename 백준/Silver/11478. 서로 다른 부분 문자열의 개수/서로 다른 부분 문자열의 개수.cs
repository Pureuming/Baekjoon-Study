using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string input = sr.ReadLine();
        HashSet<string> hash = new HashSet<string>();

        for (int i = 0; i < input.Length; i++)
        {
            string temp = "";
            
            for (int j = i; j < input.Length; j++)
            {
                temp += input[j];
                hash.Add(temp);
            }
        }
        
        sw.Write(hash.Count);
    }
}