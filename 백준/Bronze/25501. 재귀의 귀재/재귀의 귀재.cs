using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine();
            count = 1;
            sb.Append(isPalindrome(input)).Append(" ").AppendLine(count.ToString());
        }
        
        sw.Write(sb);
    }

    static int count;

    static int recursion(string s, int l, int r)
    {
        if (l >= r) return 1;
        if (s[l] != s[r]) return 0;
        count++;
        return recursion(s, l + 1, r - 1);
    }

    static int isPalindrome(string s)
    {
        return recursion(s, 0, s.Length - 1);
    }
}