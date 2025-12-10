using System.IO;
using System.Text;

class Backjoon
{
    static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string input;
        while ((input = sr.ReadLine()) != null)
        {
            int n = int.Parse(input);

            Cantor(n);
            sb.AppendLine();
        }
        sw.Write(sb);
    }

    static void Cantor(int n)
    {
        int count = (int)Math.Pow(3, n);
        char[] arr = new char[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = '-';
        }
        
        Space(arr, 0, count);
        
        sb.Append(new string(arr));
    }

    static void Space(char[] arr, int start, int count)
    {
        if (count == 1) return;
        
        int newCount = count / 3;

        for (int i = newCount; i < newCount * 2; i++)
        {
            arr[start + i] = ' ';
        }
        
        Space(arr, start, newCount);
        Space(arr, start + newCount * 2, newCount);
    }
}