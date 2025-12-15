using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string input = sr.ReadLine();

            if (input == "0") break;

            bool Palindrome = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    Palindrome = false;
                }
            }
            
            sb.AppendLine(Palindrome ? "yes" : "no");
        }
        sw.Write(sb);
    }
}