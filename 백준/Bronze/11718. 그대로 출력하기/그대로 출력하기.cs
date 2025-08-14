using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == null)
            {
                break;
            }
            sb.AppendLine(input);
        }
        Console.Write(sb.ToString().TrimEnd());
    }
}