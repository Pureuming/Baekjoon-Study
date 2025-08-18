using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i < count * 2; i++)
        {
            if (i <= count)
            {
                for (int j = 0; j < count - i; j++)
                {
                    sb.Append(" ");
                }
            }
            else
            {
                for (int j = 0; j < i - count; j++)
                {
                    sb.Append(" ");
                }
            }

            if (i <= count)
            {
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    sb.Append("*");
                }
            }
            else
            {
                for (int j = 0; j < (count * 2 - i) * 2 - 1; j++)
                {
                    sb.Append("*");
                }
            }
            sb.AppendLine();
        }
        Console.Write(sb.ToString());
    }
}