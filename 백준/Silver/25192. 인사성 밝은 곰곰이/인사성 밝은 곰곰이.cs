using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        HashSet<string> hash = new HashSet<string>();
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            string nickname = sr.ReadLine();

            if (nickname == "ENTER")
            {
                hash.Clear();
                continue;
            }

            if (hash.Contains(nickname)) continue;
            
            hash.Add(nickname);
            result++;
        }
        sw.Write(result);
    }
}