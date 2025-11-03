using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        HashSet<int> A = new HashSet<int>();
        HashSet<int> B = new HashSet<int>();
        
        string[] numA = sr.ReadLine().Split();
        for (int i = 0; i < a; i++)
        {
            A.Add(int.Parse(numA[i]));
        }
        
        string[] numB = sr.ReadLine().Split();
        for (int i = 0; i < b; i++)
        {
            B.Add(int.Parse(numB[i]));
        }

        int count = 0;
        foreach (var num in A)
        {
            if (B.Contains(num))
                count++;
        }

        sw.Write(A.Count + B.Count - 2 * count);
    }
}