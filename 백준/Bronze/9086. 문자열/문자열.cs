using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string number = Console.ReadLine();
        int count = int.Parse(number);

        for (int i = 0; i < count; i++)
        {
            string str = Console.ReadLine();
            sb.Append(str.Substring(0, 1));
            sb.AppendLine(str.Substring(str.Length - 1, 1));
        }
        Console.Write(sb.ToString());
    }
}