using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        HashSet<string> hash = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            string a = input[0];
            string b = input[1];

            if (a == "ChongChong" || b == "ChongChong")
            {
                hash.Add(a);
                hash.Add(b);
                continue;
            }

            if (hash.Contains(a) || hash.Contains(b))
            {
                hash.Add(a);
                hash.Add(b);
            }
        }
        sw.Write(hash.Count);
    }
}