using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int cent = int.Parse(Console.ReadLine());

            int quarter = cent / 25;
            sb.Append(quarter).Append(' ');
            cent %= 25;

            int dime = cent / 10;
            sb.Append(dime).Append(' ');
            cent %= 10;

            int nickel = cent / 5;
            sb.Append(nickel).Append(' ');
            cent %= 5;

            int penny = cent;
            sb.Append(penny);
            sb.AppendLine();
        }
        Console.Write(sb.ToString().TrimEnd());
    }
}