using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                if (j < count - i - 1) sb.Append(" ");
                else sb.Append("*");
            }
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
}